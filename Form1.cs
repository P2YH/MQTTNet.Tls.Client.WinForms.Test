using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using MQTTnet.Client.Receiving;
using MQTTnet.Client.Subscribing;
using MQTTnet.Formatter;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMQTTTls
{
    public partial class Form1 : Form
    {
        private bool isConnect = false;
        private IMqttClient mqttClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isConnect)
            {
                this.mqttClient.DisconnectAsync();
                this.isConnect = false;
                this.button1.Text = "connect";
            }
            else
            {
                IMqttClientOptions mqttClientOptions = getConnectOptions();
                if(mqttClientOptions != null)
                {
                    connect(mqttClientOptions);
                    this.isConnect = true;
                    this.button1.Text = "disconnect";
                }
            }
            
   
        }

        private IMqttClientOptions getConnectOptions()
        {
            string clientId = this.textBoxClientId.Text.Trim();
            if (String.IsNullOrEmpty(clientId))
            {
                MessageBox.Show("ClientId canot be null");
                return null;
            }
            string host = this.textBoxHost.Text.Trim();
            if (String.IsNullOrEmpty(host))
            {
                MessageBox.Show("host canot be null");
                return null;
            }

            string portStr = this.textBoxPort.Text.Trim();
            if (String.IsNullOrEmpty(portStr))
            {
                MessageBox.Show("port canot be null");
                return null;
            }
            int port = int.Parse(portStr);

            string userName = this.textBoxUserName.Text.Trim();
            string pwd = this.textBoxPwd.Text.Trim();

            var caCert = X509Certificate.CreateFromCertFile(this.textBoxCAFile.Text.Trim());
            CombineToPfx();
            var clientCert = new X509Certificate2("D:\\crt\\client.pfx");
            Console.WriteLine(clientCert.ToString());
            Console.WriteLine(clientCert.HasPrivateKey);
            var options = new MqttClientOptionsBuilder()
                .WithClientId(clientId)
                .WithTcpServer(host, port)
                .WithCredentials(userName, pwd)
                .WithTls(new MqttClientOptionsBuilderTlsParameters()
                {
                    UseTls = true,
                    AllowUntrustedCertificates = true,
                    IgnoreCertificateChainErrors = true,
                    IgnoreCertificateRevocationErrors = true,
                    //SslProtocol = SslProtocols.Tls,
                    Certificates = new List<X509Certificate>()
                        {
                            caCert, clientCert
                        }
                })
                .WithCleanSession()
                .WithProtocolVersion(MqttProtocolVersion.V311)
                .Build();
            return options;
        }

        private async void connect(IMqttClientOptions options)
        {
            var factory = new MqttFactory();
            this.mqttClient = factory.CreateMqttClient();
            this.mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(OnSubscriberConnected);
            
            this.mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(OnSubscriberDisconnected);
            this.mqttClient.ApplicationMessageReceivedHandler = new MqttApplicationMessageReceivedHandlerDelegate(OnSubscriberMessageReceived);
            try
            {
                await this.mqttClient.ConnectAsync(options, CancellationToken.None);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void CombineToPfx()
        {
            try
            {
                if (this.textBoxCCertFile.Text.Length != 0 && this.textBoxCKFile.Text.Length != 0)
                {
                    string crt = File.ReadAllText(this.textBoxCCertFile.Text);
                    string key = File.ReadAllText(this.textBoxCKFile.Text);
                    WritePfx(crt, key, "", "D:\\crt\\client.pfx");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
  
        }

        private bool WritePfx(string certPem, string keyPem, string password, string filePath)
        {
            var cert = ReadCertificate(certPem);
            var certEntry = new X509CertificateEntry(cert);

            if (certEntry?.Certificate == null)
                throw new ArgumentException("The string given as a PEM representation of the certificate could not be read accordingly.", nameof(certPem));

            AsymmetricKeyParameter privKey = null;
            if (!string.IsNullOrEmpty(keyPem))
            {
                privKey = ReadPrivateKey(keyPem);
                if (privKey == null)
                    throw new ArgumentException("The string given as a PEM representation of the private key could not be read accordingly.", nameof(keyPem));
            }

            var store = new Pkcs12StoreBuilder().Build();
            if (privKey != null)
            {
                var chain = new X509CertificateEntry[] { certEntry };
                store.SetKeyEntry("", new AsymmetricKeyEntry(privKey), chain);
            }
            else
                store.SetCertificateEntry("", certEntry);

            using (var p12file = File.Create(filePath))
            {
                store.Save(p12file, password.ToCharArray(), new SecureRandom());
            }
            return privKey != null;
        }

        private Org.BouncyCastle.X509.X509Certificate ReadCertificate(string certPem)
        {
            using (var sr = new StringReader(certPem))
            {
                var pemReader = new PemReader(sr);
                return (Org.BouncyCastle.X509.X509Certificate)pemReader.ReadObject();
            }
        }

        private AsymmetricKeyParameter ReadPrivateKey(string keyPem)
        {
            AsymmetricKeyParameter result;
            using (var stringReader = new StringReader(keyPem))
            {
                var pemReader = new PemReader(stringReader);
                var pemObject = pemReader.ReadObject();
                result = ((AsymmetricCipherKeyPair)pemObject).Private;
            }

            return result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            publishMsg();
        }

        private async void publishMsg()
        {
            //"$iot/v1/device/71e0d1737cb3100/events/post"
            string topic = textBoxTopic.Text;
            string text = textBox1.Text;
            try
            {
                var message = new MqttApplicationMessageBuilder()
                           .WithTopic(topic)
                           .WithPayload(text)
                           .WithExactlyOnceQoS()
                           .WithRetainFlag()
                           .Build();

                await this.mqttClient.PublishAsync(message, CancellationToken.None);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void OnSubscriberMessageReceived(MqttApplicationMessageReceivedEventArgs x)
        {
            var item = $"Timestamp: {DateTime.Now:O} | Topic: {x.ApplicationMessage.Topic} | Payload: {x.ApplicationMessage.ConvertPayloadToString()} | QoS: {x.ApplicationMessage.QualityOfServiceLevel}";
            this.BeginInvoke((MethodInvoker)delegate { this.textBoxRec.Text = item + Environment.NewLine + this.textBoxRec.Text; });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.mqttClient.DisconnectAsync();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var topicFilter = new MqttTopicFilter { Topic = this.textBoxTopic.Text.Trim() };
            await this.mqttClient.SubscribeAsync(topicFilter);
            MessageBox.Show("Topic " + this.textBoxTopic.Text.Trim() + " is subscribed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private static void OnSubscriberConnected(MqttClientConnectedEventArgs x)
        {
            MessageBox.Show("Subscriber Connected", "ConnectHandler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the subscriber disconnected event.
        /// </summary>
        /// <param name="x">The MQTT client disconnected event args.</param>
        private static void OnSubscriberDisconnected(MqttClientDisconnectedEventArgs x)
        {
            MessageBox.Show("Subscriber Disconnected", "ConnectHandler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCAFile_Click(object sender, EventArgs e)
        {
            textBoxCAFile.Text = openFile(1).Trim();
        }

        private string openFile(int index)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //设置打开对话框的初始目录，默认目录为exe运行文件所在的路径
            ofd.InitialDirectory = Application.StartupPath;
            //设置打开对话框的标题
            ofd.Title = "请选择要打开的文件";
            //设置打开对话框可以多选
            ofd.Multiselect = true;
            //设置对话框打开的文件类型
            ofd.Filter = "密钥文件|*.crt|密钥Key|*.key|所有文件|*.*";
            //设置文件对话框当前选定的筛选器的索引
            ofd.FilterIndex = index;
            //设置对话框是否记忆之前打开的目录
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择的文件完整路径
                string filePath = ofd.FileName;
                return filePath;
            }
            return "";
        }

        private void btnCCFile_Click(object sender, EventArgs e)
        {
            this.textBoxCCertFile.Text = openFile(1).Trim();
        }

        private void buttonCKFile_Click(object sender, EventArgs e)
        {
            this.textBoxCKFile.Text = openFile(2).Trim();
        }
    }
}
