using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class UDP_client : Form
    {
        public UDP_client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(txtRemoteIP.Text, 8080);

            string msg = txtMsg.Text;
            Byte[] senddata = Encoding.ASCII.GetBytes(msg);
            udpClient.Send(senddata, senddata.Length);
        }

        private void UDP_client_Load(object sender, EventArgs e)
        {
            txtPort.Text = "8080";
        }
    }
}
