namespace eMail
{
    partial class UserControlMailAdresses
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
            this.panelRecipients = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelRecipients
            // 
            this.panelRecipients.AutoScroll = true;
            this.panelRecipients.BackColor = System.Drawing.SystemColors.Info;
            this.panelRecipients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecipients.Location = new System.Drawing.Point(0, 0);
            this.panelRecipients.Name = "panelRecipients";
            this.panelRecipients.Size = new System.Drawing.Size(347, 114);
            this.panelRecipients.TabIndex = 14;
            // 
            // UserControlMailAdresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panelRecipients);
            this.Name = "UserControlMailAdresses";
            this.Size = new System.Drawing.Size(347, 114);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRecipients;
    }
}
