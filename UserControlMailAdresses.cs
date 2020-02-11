using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace eMail
{
    public partial class UserControlMailAdresses : UserControl
    {

        public string[] Addresses
        {
            get
            {
                adresses = new System.Collections.Generic.List<string>();
                if (textBox != null)
                {
                    foreach (TextBox tb in textBox)
                        if (tb.Text != "")
                            adresses.Add(tb.Text);
                }
                if (adresses.Count > 0)
                    return adresses.ToArray();

                return null;
            }
            set
            {
                string[] tmp = value;
                adresses = new System.Collections.Generic.List<string>();
                adresses.AddRange(tmp);
            }
        }

        public UserControlMailAdresses()
        {
            InitializeComponent();
        }

        public void fillPanelRecipents()
        {
            panelRecipients.Controls.Clear();

            textBox = new System.Collections.Generic.List<TextBox>();
            button = new System.Collections.Generic.List<Button>();

            suppress = true;
            for (int i = 0; i <= adresses.Count; i++)
            {
                TextBox tb = new TextBox()
                {
                    Name = i.ToString(),
                    Size = new Size(290, 20),
                    Location = new Point(3, i * 20 + 3),
                };

                tb.TextChanged += new EventHandler(textBox_TextChanged);

                Button bt = new Button()
                {
                    Name = i.ToString(),
                    Text = null,
                    Image = global::eMail.Properties.Resources.erase,
                    Size = new Size(20, 20),
                    Location = new Point(299, i * 20 + 3),
                };
                bt.Click += new EventHandler(button_Click);
                if (i < adresses.Count)
                {
                    tb.Text = (string)adresses[i];
                }
                else
                    bt.Enabled = false;
                textBox.Add(tb);
                button.Add(bt);
            }
            panelRecipients.Controls.AddRange(textBox.ToArray());
            panelRecipients.Controls.AddRange(button.ToArray());
            suppress = false;
        }

        internal System.Collections.Generic.List<string> adresses = null;
        internal System.Collections.Generic.List<TextBox> textBox = null;
        internal System.Collections.Generic.List<Button> button = null;
        internal bool suppress = false;

        void button_Click(object sender, EventArgs e)
        {
            if (suppress)
                return;

            Button bt = (Button)sender;

            textBox.RemoveAt(int.Parse(bt.Name));
            button.RemoveAt(int.Parse(bt.Name));

            adresses = new System.Collections.Generic.List<string>();
            foreach (TextBox tb in textBox)
                if (tb.Text != "")
                    adresses.Add(tb.Text);

            fillPanelRecipents();
        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
            if (suppress)
                return;
            TextBox tb = (TextBox)sender;

            if (!button[int.Parse(tb.Name)].Enabled)
            {
                int i = int.Parse(tb.Name);
                button[i].Enabled = true;
                i++;

                TextBox tbn = new TextBox()
                {
                    Name = i.ToString(),
                    Size = new Size(290, 20),
                    Location = new Point(3, i * 20 + 3),
                };

                tbn.TextChanged += new EventHandler(textBox_TextChanged);
                textBox.Add(tbn);

                Button btn = new Button()
                {
                    Name = i.ToString(),
                    Text = null,
                    Image = global::eMail.Properties.Resources.erase,
                    Size = new Size(20, 20),
                    Location = new Point(299, i * 20 + 3),
                    Enabled = false,
                };
                btn.Click += new EventHandler(button_Click);
                button.Add(btn);

                panelRecipients.Controls.Add(tbn);
                panelRecipients.Controls.Add(btn);
            }

            if (MailProperties.IsMailAddress(tb.Text))
                tb.ForeColor = SystemColors.WindowText;
            else
                tb.ForeColor = Color.Red;
        }
    }
}
