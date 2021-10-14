
namespace WindowsFormsMQTTTls
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxRec = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCKFile = new System.Windows.Forms.Button();
            this.btnCCFile = new System.Windows.Forms.Button();
            this.btnCAFile = new System.Windows.Forms.Button();
            this.textBoxCKFile = new System.Windows.Forms.TextBox();
            this.textBoxCCertFile = new System.Windows.Forms.TextBox();
            this.textBoxCAFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHost = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(995, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "发送消息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(877, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 281);
            this.textBox1.TabIndex = 3;
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(24, 27);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(632, 25);
            this.textBoxTopic.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(682, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "Subtopic";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxRec
            // 
            this.textBoxRec.Location = new System.Drawing.Point(24, 72);
            this.textBoxRec.Multiline = true;
            this.textBoxRec.Name = "textBoxRec";
            this.textBoxRec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRec.Size = new System.Drawing.Size(792, 276);
            this.textBoxRec.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Port);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPort);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxClientId);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPwd);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxUserName);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxHost);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.labelHost);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTopic);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxRec);
            this.splitContainer1.Size = new System.Drawing.Size(1190, 716);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCKFile);
            this.groupBox1.Controls.Add(this.btnCCFile);
            this.groupBox1.Controls.Add(this.btnCAFile);
            this.groupBox1.Controls.Add(this.textBoxCKFile);
            this.groupBox1.Controls.Add(this.textBoxCCertFile);
            this.groupBox1.Controls.Add(this.textBoxCAFile);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Certificates";
            // 
            // buttonCKFile
            // 
            this.buttonCKFile.Location = new System.Drawing.Point(631, 105);
            this.buttonCKFile.Name = "buttonCKFile";
            this.buttonCKFile.Size = new System.Drawing.Size(39, 23);
            this.buttonCKFile.TabIndex = 4;
            this.buttonCKFile.Text = "...";
            this.buttonCKFile.UseVisualStyleBackColor = true;
            this.buttonCKFile.Click += new System.EventHandler(this.buttonCKFile_Click);
            // 
            // btnCCFile
            // 
            this.btnCCFile.Location = new System.Drawing.Point(631, 75);
            this.btnCCFile.Name = "btnCCFile";
            this.btnCCFile.Size = new System.Drawing.Size(39, 23);
            this.btnCCFile.TabIndex = 4;
            this.btnCCFile.Text = "...";
            this.btnCCFile.UseVisualStyleBackColor = true;
            this.btnCCFile.Click += new System.EventHandler(this.btnCCFile_Click);
            // 
            // btnCAFile
            // 
            this.btnCAFile.Location = new System.Drawing.Point(631, 44);
            this.btnCAFile.Name = "btnCAFile";
            this.btnCAFile.Size = new System.Drawing.Size(39, 23);
            this.btnCAFile.TabIndex = 4;
            this.btnCAFile.Text = "...";
            this.btnCAFile.UseVisualStyleBackColor = true;
            this.btnCAFile.Click += new System.EventHandler(this.btnCAFile_Click);
            // 
            // textBoxCKFile
            // 
            this.textBoxCKFile.Location = new System.Drawing.Point(240, 106);
            this.textBoxCKFile.Name = "textBoxCKFile";
            this.textBoxCKFile.Size = new System.Drawing.Size(385, 25);
            this.textBoxCKFile.TabIndex = 3;
            // 
            // textBoxCCertFile
            // 
            this.textBoxCCertFile.Location = new System.Drawing.Point(240, 75);
            this.textBoxCCertFile.Name = "textBoxCCertFile";
            this.textBoxCCertFile.Size = new System.Drawing.Size(385, 25);
            this.textBoxCCertFile.TabIndex = 3;
            // 
            // textBoxCAFile
            // 
            this.textBoxCAFile.Location = new System.Drawing.Point(240, 44);
            this.textBoxCAFile.Name = "textBoxCAFile";
            this.textBoxCAFile.Size = new System.Drawing.Size(385, 25);
            this.textBoxCAFile.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Client key file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Client Certificate File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "CA File";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(465, 55);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(39, 15);
            this.Port.TabIndex = 3;
            this.Port.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(510, 48);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(146, 25);
            this.textBoxPort.TabIndex = 2;
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(84, 17);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(572, 25);
            this.textBoxClientId.TabIndex = 1;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(447, 85);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(209, 25);
            this.textBoxPwd.TabIndex = 1;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(84, 85);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(280, 25);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(84, 48);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(375, 25);
            this.textBoxHost.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClientId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(39, 48);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(39, 15);
            this.labelHost.TabIndex = 0;
            this.labelHost.Text = "Host";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxRec;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox textBoxCKFile;
        private System.Windows.Forms.TextBox textBoxCCertFile;
        private System.Windows.Forms.TextBox textBoxCAFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCAFile;
        private System.Windows.Forms.Button buttonCKFile;
        private System.Windows.Forms.Button btnCCFile;
    }
}

