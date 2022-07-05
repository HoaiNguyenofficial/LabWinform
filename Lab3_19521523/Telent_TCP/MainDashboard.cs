using Client;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telent_TCP;

namespace TCP
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UDP_server().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TCP_telnet().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TCP_Dashboard().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Multichat_server().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Multichat_client().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new UDP_client().Show();
        }
    }
}
