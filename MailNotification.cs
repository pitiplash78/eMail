using System;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Net.Mail;

namespace eMail
{
    public static class eMail
    {
        public static bool Send(MailProperties mailProperties, String Subject, string Body, bool ErrorMessage)
        {
            // TODO fertig machen von zertificaTEN falls notig | wie sieht es mit mail empfangen aus?
            try
            {
                MailMessage mail = new MailMessage();

                SmtpClient SmtpServer = new SmtpClient(mailProperties.SMTPclient); //SMTP Server von Hotmail und Outlook. 
                SmtpServer.Port = mailProperties.SMTPclientPort;
                SmtpServer.EnableSsl = mailProperties.EnableSsl;

                mail.From = new MailAddress(mailProperties.SenderAddress); //Absender

                for (int i = 0; i < mailProperties.RecipientAdresses.Length; i++)
                    mail.To.Add(mailProperties.RecipientAdresses[i]); //Empfänger 

                mail.Subject = Subject;

                mail.Body = Body;

                //mail.IsBodyHtml = true; //Nur wenn Body HTML Quellcode ist  

                if (mailProperties.SenderUserName != null && mailProperties.SenderPassword != null)
                {
                    SmtpServer.Credentials = new System.Net.NetworkCredential(mailProperties.SenderUserName, MailProperties.SimpleEncode(mailProperties.SenderPassword));
                }

                // ServicePointManager.ServerCertificateValidationCallback =
                //     delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                //     {
                //         return true;
                //     };

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                if (ErrorMessage)
                    MessageBox.Show("Error on sending Mail!" + Environment.NewLine + Environment.NewLine +
                                    "Sender:    " + mailProperties.SenderAddress + Environment.NewLine +
                                    "Subject:   " + Subject + Environment.NewLine +
                                    "Body:      " + Environment.NewLine +
                                    Body + Environment.NewLine + Environment.NewLine +
                                    "Error:     " + ex.Message, "Mail notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public class MailProperties
    {
        /// <summary>
        /// Flag for using the mail notification or not
        /// </summary>
        [XmlElement("Used")]
        public bool Used = true;

        /// <summary>
        /// Full mail adress of the sender.
        /// </summary>
        [XmlElement("SenderAddress")]
        public string SenderAddress = null;

        /// <summary>
        /// Optional user name of the sender.
        /// </summary>
        [XmlElement("SenderUserName")]
        public string SenderUserName = null; 

        /// <summary>
        /// Optional user password of the sender.
        /// </summary>
        [XmlElement("SenderPassword")]
        public string SenderPassword = null;

        /// <summary>
        /// List of the recipient adresses.
        /// </summary>
        [XmlArray("RecipientAdresses")]
        public string[] RecipientAdresses = null;

        /// <summary>
        /// SMTP client name.
        /// </summary>
        [XmlElement("SMTPclient")]
        public string SMTPclient = null;

        /// <summary>
        /// SMTP client port.
        /// </summary>
        [XmlElement("SMTPclientPort")]
        public int SMTPclientPort = 25;

        /// <summary>
        /// Optional flag for using TSL/SsL coding.
        /// </summary>
        [XmlElement("EnableSsl")]
        public bool EnableSsl = false;

        public MailProperties()
        {

        }

        /// <summary>
        /// Simple encoding for a string.
        /// </summary>
        /// <param name="str">String to encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string SimpleEncode(string str)
        {
            string result = null;
            for (int i = 0; i < str.Length; ++i)
                result = string.Concat(result, (char)(str[i] - 1));
            return result;
        }

        /// <summary>
        /// Simple decoding for a string.
        /// </summary>
        /// <param name="str">String to decoded.</param>
        /// <returns>Decoded string.</returns>
        public static string SimpleDecode(string str)
        {
            string result = null;
            for (int i = 0; i < str.Length; ++i)
                result = string.Concat(result, (char)(str[i] + 1));
            return result;
        }

        /// <summary>
        /// Serialization of the ETDDT class by using the properties path.
        /// </summary>
        /// <param name="etddt"> object ETDDT</param>
        public static void serialisieren(MailProperties mailProperties, string path)
        {
            XmlSerializer s = new XmlSerializer(typeof(MailProperties));
            TextWriter w = new StreamWriter(path);
            s.Serialize(w, mailProperties);
            w.Close();
        }

        /// <summary>
        /// Deserialization of the ETDDT class by using the properties path.
        /// </summary>
        /// <returns>object ETDDT</returns>
        public static MailProperties deserialisieren(string path)
        {
            MailProperties mailProperties;
            XmlSerializer s = new XmlSerializer(typeof(MailProperties));
            TextReader r = new StreamReader(path);
            mailProperties = (MailProperties)s.Deserialize(r);
            r.Close();
            return mailProperties;
        }

        /// Determines whether the specified email address is in a valid format (RFC 822).
        /// </summary>
        /// <param name="MailAddress">Email address to validate.</param>
        /// <returns><c>True</c> if the email address is formatted correctly, otherwise <c>False</c>.</returns>
        /// <remarks></remarks>
        public static bool IsMailAddress(String MailAddress)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(MailAddress, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }
    }
}
