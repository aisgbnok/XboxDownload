﻿namespace XboxDownload
{
    partial class FormConnectTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbHostName = new TextBox();
            label2 = new Label();
            tbIP = new TextBox();
            label3 = new Label();
            tbPort = new TextBox();
            tbMessage = new TextBox();
            butTest = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 0;
            label1.Text = "域名";
            // 
            // tbHostName
            // 
            tbHostName.Location = new Point(76, 23);
            tbHostName.Name = "tbHostName";
            tbHostName.Size = new Size(412, 30);
            tbHostName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 62);
            label2.Name = "label2";
            label2.Size = new Size(26, 24);
            label2.TabIndex = 2;
            label2.Text = "IP";
            // 
            // tbIP
            // 
            tbIP.Location = new Point(76, 59);
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(543, 30);
            tbIP.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 26);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 4;
            label3.Text = "端口";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(546, 26);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(73, 30);
            tbPort.TabIndex = 2;
            tbPort.Text = "443";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(76, 95);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(696, 151);
            tbMessage.TabIndex = 100;
            // 
            // butTest
            // 
            butTest.Location = new Point(625, 23);
            butTest.Name = "butTest";
            butTest.Size = new Size(147, 66);
            butTest.TabIndex = 4;
            butTest.Text = "检测";
            butTest.UseVisualStyleBackColor = true;
            butTest.Click += ButTest_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 95);
            label4.Name = "label4";
            label4.Size = new Size(46, 24);
            label4.TabIndex = 101;
            label4.Text = "结果";
            // 
            // FormConnectTest
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 264);
            Controls.Add(label4);
            Controls.Add(butTest);
            Controls.Add(tbMessage);
            Controls.Add(tbPort);
            Controls.Add(label3);
            Controls.Add(tbIP);
            Controls.Add(label2);
            Controls.Add(tbHostName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConnectTest";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "检测连接（只测试TLS握手，部分不使用公共证书域名无法通过测试）";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbHostName;
        private Label label2;
        private TextBox tbIP;
        private Label label3;
        private TextBox tbPort;
        private TextBox tbMessage;
        private Button butTest;
        private Label label4;
    }
}