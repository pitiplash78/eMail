using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMail
{
    public partial class UserControlMailProperties : UserControl
    {
        public MailProperties MailProperties
        {
            get
            {
                if (mailProperties == null)
                    mailProperties = new global::eMail.MailProperties();

                if (textBoxSender.Text == "")
                    mailProperties.SenderAddress = null;
                else
                    mailProperties.SenderAddress = textBoxSender.Text;

                if (textBoxUserName.Text == "")
                    mailProperties.SenderUserName = null;
                else
                    mailProperties.SenderUserName = textBoxUserName.Text;

                if (textBoxUserPassword.Text == "")
                    mailProperties.SenderPassword = null;
                else
                    mailProperties.SenderPassword = MailProperties.SimpleEncode(textBoxUserPassword.Text);

                mailProperties.SMTPclient = textBoxSMTPserver.Text;
                mailProperties.SMTPclientPort = (int)numericUpDownPort.Value;

                mailProperties.EnableSsl = checkBoxSSL.Checked;

                mailProperties.RecipientAdresses = userControlMailAdresses.Addresses;

                if (mailProperties.SenderAddress == null || mailProperties.SMTPclient == null || mailProperties.RecipientAdresses == null)
                    mailProperties = null;

                return mailProperties;
            }
            set
            {
                mailProperties = value;
                setProperties();
            }
        }
        internal MailProperties mailProperties = null;

        public bool ValidProperites
        {
            get
            {
                if (mailProperties != null)
                {
                    if (!MailProperties.IsMailAddress(textBoxSender.Text))
                        return false;

                    if (textBoxSMTPserver.Text == "")
                        return false;

                    if (mailProperties.RecipientAdresses.Length > 0)
                    {
                        foreach (string s in mailProperties.RecipientAdresses)
                            if (!MailProperties.IsMailAddress(s))
                                return false;
                    }
                    else
                        return false;
                    return true;
                }
                else
                    return false;
            }
            set { }
        }

        public UserControlMailProperties()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxShowPassword.Checked)
                textBoxUserPassword.PasswordChar = '*';
            else
                textBoxUserPassword.PasswordChar = '\0';
            textBoxUserPassword.Focus();
        }

        private void setProperties()
        {
            if (mailProperties != null)
            {
                textBoxSender.Text = mailProperties.SenderAddress;
                textBoxUserName.Text = mailProperties.SenderUserName;
                textBoxUserPassword.Text = mailProperties.SenderPassword;
                textBoxSMTPserver.Text = mailProperties.SMTPclient;
                numericUpDownPort.Value = (decimal)mailProperties.SMTPclientPort;
                checkBoxSSL.Checked = mailProperties.EnableSsl;

                userControlMailAdresses.Addresses = mailProperties.RecipientAdresses;
            }
            userControlMailAdresses.fillPanelRecipents();
        }
        private void textBoxSender_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (MailProperties.IsMailAddress(tb.Text))
                tb.ForeColor = SystemColors.WindowText;
            else
                tb.ForeColor = Color.Red;
        }

        private void buttonSendTestMail_Click(object sender, EventArgs e)
        {
            if(eMail.Send(mailProperties,"Notification test", "Test Mesasge!",true))
                MessageBox.Show("Mail is delivered!","Mail notification test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
