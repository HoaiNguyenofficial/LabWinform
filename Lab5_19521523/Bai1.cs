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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient= new SmtpClient("127.0.0.1"))
            {
                string mailfrom = txtFrom.Text.ToString().Trim();
                string mailto = txtTo.Text.ToString().Trim();
                string password = txtPassword.Text.ToString().Trim();

                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    message.From = fromAddress;
                    message.Subject = txtSubject.Text.ToString().Trim();
                    //set IsBodyHTML to true means you cand send HTML email
                    message.IsBodyHtml = true;
                    message.Body = richTextBox1.Text.ToString();
                    message.To.Add(mailto);

                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Sucess");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString(),"Error");
                    }

                }    
                    

                
            }    
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
