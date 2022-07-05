using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;

namespace Lab5_19521523
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var emailClient = new ImapClient())
            {
                try
                {
                    string mail = txtEmail.Text.ToString().Trim();
                    string password = txtPassword.Text.ToString().Trim();

                    emailClient.Connect("127.0.0.1", 143, 0);
                    emailClient.Authenticate(mail, password);
                    var inbox = emailClient.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    listView1.Columns.Add("Email", 350);
                    listView1.Columns.Add("From", 250);
                    listView1.Columns.Add("Time", 150);
                    listView1.View = View.Details;
                    for(int i=0;i<inbox.Count;i++)
                    {
                        var msg = inbox.GetMessage(i);
                        ListViewItem lsI = new ListViewItem(msg.Subject);
                        lsI.SubItems.Add(msg.From.ToString());
                        lsI.SubItems.Add(msg.Date.Date.ToString());
                        listView1.Items.Add(lsI);
                    }
                    lbTotal.Text = inbox.Count.ToString();
                    lbRecent.Text = inbox.Recent.ToString();

                    emailClient.Disconnect(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
