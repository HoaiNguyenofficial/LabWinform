using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_19521523
{
    public partial class Bai3_Check : Form
    {
        public Bai3_Check()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using(var emailClient = new ImapClient())
            {
                try
                {
                    emailClient.Connect("127.0.0.1", 143, 0);
                    emailClient.Authenticate(Bai3.user, Bai3.password);
                    var inbox = emailClient.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    listView1.Columns.Add("Email", 350);
                    listView1.Columns.Add("From", 250);
                    listView1.Columns.Add("Time", 150);
                    listView1.View = View.Details;
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem lvi = new ListViewItem(message.Subject);
                        lvi.SubItems.Add(message.From.ToString());
                        lvi.SubItems.Add(message.Date.Date.ToString());
                        listView1.Items.Add(lvi);
                    }
                    lbTotal.Text = inbox.Count.ToString();
                    lbRecent.Text = inbox.Recent.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Bai3_Send().Show();
        }
    }
}
