namespace eMail
{
    partial class UserControlMailProperties
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSMTPserver = new System.Windows.Forms.TextBox();
            this.checkBoxSSL = new System.Windows.Forms.CheckBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelSender = new System.Windows.Forms.Label();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.buttonSendTestMail = new System.Windows.Forms.Button();
            this.userControlMailAdresses = new UserControlMailAdresses();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(233, 127);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPort.TabIndex = 32;
            this.numericUpDownPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "SMTP server:";
            // 
            // textBoxSMTPserver
            // 
            this.textBoxSMTPserver.Location = new System.Drawing.Point(81, 105);
            this.textBoxSMTPserver.Name = "textBoxSMTPserver";
            this.textBoxSMTPserver.Size = new System.Drawing.Size(272, 20);
            this.textBoxSMTPserver.TabIndex = 29;
            // 
            // checkBoxSSL
            // 
            this.checkBoxSSL.AutoSize = true;
            this.checkBoxSSL.Checked = true;
            this.checkBoxSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSSL.Location = new System.Drawing.Point(81, 157);
            this.checkBoxSSL.Name = "checkBoxSSL";
            this.checkBoxSSL.Size = new System.Drawing.Size(112, 17);
            this.checkBoxSSL.TabIndex = 28;
            this.checkBoxSSL.Text = "SSL/TSL enabled";
            this.checkBoxSSL.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(222, 82);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(101, 17);
            this.checkBoxShowPassword.TabIndex = 27;
            this.checkBoxShowPassword.Text = "Show password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Recipient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "User pasword (optional):";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(206, 55);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(147, 20);
            this.textBoxUserPassword.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "User name (optional):";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(206, 29);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(147, 20);
            this.textBoxUserName.TabIndex = 22;
            // 
            // labelSender
            // 
            this.labelSender.AutoSize = true;
            this.labelSender.Location = new System.Drawing.Point(3, 6);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(44, 13);
            this.labelSender.TabIndex = 21;
            this.labelSender.Text = "Sender:";
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(81, 3);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(272, 20);
            this.textBoxSender.TabIndex = 20;
            this.textBoxSender.TextChanged += new System.EventHandler(this.textBoxSender_TextChanged);
            // 
            // buttonSendTestMail
            // 
            this.buttonSendTestMail.Location = new System.Drawing.Point(6, 320);
            this.buttonSendTestMail.Name = "buttonSendTestMail";
            this.buttonSendTestMail.Size = new System.Drawing.Size(347, 23);
            this.buttonSendTestMail.TabIndex = 34;
            this.buttonSendTestMail.Text = "Send test mail ...";
            this.buttonSendTestMail.UseVisualStyleBackColor = true;
            this.buttonSendTestMail.Click += new System.EventHandler(this.buttonSendTestMail_Click);
            // 
            // userControlMailAdresses
            // 
            this.userControlMailAdresses.Addresses = new string[0];
            this.userControlMailAdresses.Location = new System.Drawing.Point(6, 200);
            this.userControlMailAdresses.Name = "userControlMailAdresses";
            this.userControlMailAdresses.Size = new System.Drawing.Size(347, 114);
            this.userControlMailAdresses.TabIndex = 33;
            // 
            // UserControlMailProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSendTestMail);
            this.Controls.Add(this.userControlMailAdresses);
            this.Controls.Add(this.numericUpDownPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSMTPserver);
            this.Controls.Add(this.checkBoxSSL);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelSender);
            this.Controls.Add(this.textBoxSender);
            this.Name = "UserControlMailProperties";
            this.Size = new System.Drawing.Size(442, 383);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlMailAdresses userControlMailAdresses;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSMTPserver;
        private System.Windows.Forms.CheckBox checkBoxSSL;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.Button buttonSendTestMail;
    }
}
