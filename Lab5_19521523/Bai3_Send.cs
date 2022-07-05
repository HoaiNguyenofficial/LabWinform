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

namespace Lab5_19521523
{
    public partial class Bai3_Send : Form
    {
        public Bai3_Send()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtp = new SmtpClient("127.0.0.1"))
            {
                string mailFrom = Bai3.user;
                string mailTo = txtTo.Text.Trim();
                string password = Bai3.password;
                var basicCredential = new NetworkCredential(mailFrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailFrom);
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = txtSubject.Text.Trim();
                    message.IsBodyHtml = true;
                    message.Body = richTextBox1.Text;
                    message.To.Add(mailTo);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Send successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
