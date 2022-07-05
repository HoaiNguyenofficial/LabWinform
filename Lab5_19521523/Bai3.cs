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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        public static string user;
        public static string password;
        private void btnLogin_Click(object sender, EventArgs e)
        {
             user = txtEmail.Text.Trim();
             password = txtPassword.Text.Trim();
            var emaiClient = new ImapClient();
            try
            {
                emaiClient.Connect("127.0.0.1", 143, 0);
                emaiClient.Authenticate(user, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            new Bai3_Check().Show();
            this.Close();
        }
    }
}
