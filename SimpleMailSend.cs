using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMail
{
    public partial class SimpleMailSend : Form
    {
        public MailProperties MailProperties { get; private set; }
        public bool ReportErrors { get; private set; }
        public string Subject = null;
        public string Body = null;

        public SimpleMailSend(MailProperties MailProperties, bool ReportErrors, string Subject = null, string Body = null)
        {
            this.MailProperties = MailProperties;
            this.ReportErrors = ReportErrors;

            InitializeComponent();

            if (Subject != null)
            {
                this.Subject = Subject;
                textBoxSubject.Text = Subject;
            }
            if (Body != null)
            {
                this.Body = Body;
                textBoxBody.Text = Body;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Subject = textBoxSubject.Text;
            Body = textBoxBody.Text;

            if(Subject == "" && Body == "")
            {
                MessageBox.Show("Subject and body of the mail is empty!", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Subject == "" || Body == "")
            {
                if (Subject == "")
                {
                    if (MessageBox.Show("Subject of the mail is empty! Send it anyway?",
                        this.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.No)
                        return;

                }
                if (Body == "")
                {
                    if (MessageBox.Show("Body of the mail is empty! Send it anyway?",
                        this.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.No)
                        return;

                }
            }

            eMail.Send(MailProperties, Subject, Body, ReportErrors);

            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
