namespace Computer_RS232_Chat_.NET
{
    partial class ChatClient
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
            this.TxtRecievedBx = new System.Windows.Forms.TextBox();
            this.TxtToSendBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortBx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BaudBx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ParityBx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenPortBttn = new System.Windows.Forms.Button();
            this.ClosePortBttn = new System.Windows.Forms.Button();
            this.PortActivePic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PortActivePic)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRecievedBx
            // 
            this.TxtRecievedBx.Location = new System.Drawing.Point(293, 92);
            this.TxtRecievedBx.Multiline = true;
            this.TxtRecievedBx.Name = "TxtRecievedBx";
            this.TxtRecievedBx.ReadOnly = true;
            this.TxtRecievedBx.Size = new System.Drawing.Size(273, 222);
            this.TxtRecievedBx.TabIndex = 0;
            // 
            // TxtToSendBx
            // 
            this.TxtToSendBx.Location = new System.Drawing.Point(12, 92);
            this.TxtToSendBx.Multiline = true;
            this.TxtToSendBx.Name = "TxtToSendBx";
            this.TxtToSendBx.Size = new System.Drawing.Size(258, 222);
            this.TxtToSendBx.TabIndex = 1;
            this.TxtToSendBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtToSendBx_KeyDown);
            this.TxtToSendBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtToSendBx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(102, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text to send";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(387, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text Recieved";
            // 
            // PortBx
            // 
            this.PortBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortBx.FormattingEnabled = true;
            this.PortBx.Location = new System.Drawing.Point(77, 36);
            this.PortBx.Name = "PortBx";
            this.PortBx.Size = new System.Drawing.Size(121, 21);
            this.PortBx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(107, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Serial Ports";
            // 
            // BaudBx
            // 
            this.BaudBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudBx.FormattingEnabled = true;
            this.BaudBx.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "256000"});
            this.BaudBx.Location = new System.Drawing.Point(222, 36);
            this.BaudBx.Name = "BaudBx";
            this.BaudBx.Size = new System.Drawing.Size(121, 21);
            this.BaudBx.TabIndex = 6;
            this.BaudBx.SelectedIndexChanged += new System.EventHandler(this.BaudBx_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(253, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Baud Rate";
            // 
            // ParityBx
            // 
            this.ParityBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityBx.FormattingEnabled = true;
            this.ParityBx.Location = new System.Drawing.Point(366, 36);
            this.ParityBx.Name = "ParityBx";
            this.ParityBx.Size = new System.Drawing.Size(121, 21);
            this.ParityBx.TabIndex = 8;
            this.ParityBx.SelectedIndexChanged += new System.EventHandler(this.ParityBx_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(411, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity";
            // 
            // OpenPortBttn
            // 
            this.OpenPortBttn.Location = new System.Drawing.Point(195, 342);
            this.OpenPortBttn.Name = "OpenPortBttn";
            this.OpenPortBttn.Size = new System.Drawing.Size(75, 23);
            this.OpenPortBttn.TabIndex = 10;
            this.OpenPortBttn.Text = "Open Port";
            this.OpenPortBttn.UseVisualStyleBackColor = true;
            this.OpenPortBttn.Click += new System.EventHandler(this.OpenPortBttn_Click);
            // 
            // ClosePortBttn
            // 
            this.ClosePortBttn.Location = new System.Drawing.Point(293, 342);
            this.ClosePortBttn.Name = "ClosePortBttn";
            this.ClosePortBttn.Size = new System.Drawing.Size(75, 23);
            this.ClosePortBttn.TabIndex = 11;
            this.ClosePortBttn.Text = "Close Port";
            this.ClosePortBttn.UseVisualStyleBackColor = true;
            this.ClosePortBttn.Click += new System.EventHandler(this.ClosePortBttn_Click);
            // 
            // PortActivePic
            // 
            this.PortActivePic.BackColor = System.Drawing.Color.Red;
            this.PortActivePic.Location = new System.Drawing.Point(303, 371);
            this.PortActivePic.Name = "PortActivePic";
            this.PortActivePic.Size = new System.Drawing.Size(18, 14);
            this.PortActivePic.TabIndex = 12;
            this.PortActivePic.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(233, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Port Active:";
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(582, 396);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PortActivePic);
            this.Controls.Add(this.ClosePortBttn);
            this.Controls.Add(this.OpenPortBttn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ParityBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BaudBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PortBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtToSendBx);
            this.Controls.Add(this.TxtRecievedBx);
            this.Name = "ChatClient";
            this.Text = "Chat Application over RS232";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PortActivePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRecievedBx;
        private System.Windows.Forms.TextBox TxtToSendBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PortBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BaudBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ParityBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OpenPortBttn;
        private System.Windows.Forms.Button ClosePortBttn;
        private System.Windows.Forms.PictureBox PortActivePic;
        private System.Windows.Forms.Label label6;
    }
}

