using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class UDP_server : Form
    {
        public UDP_server()
        {
            InitializeComponent();

        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        public void serverThread()
        {

            UdpClient udpClient = new UdpClient(8080);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                Invoke(new Action(() =>
                {
                     lsvMsg.Items.Add(RemoteIpEndPoint.Address.ToString()+ ":" + returnData.ToString());
                }));
            }
        }

        private void UDP_server_Load(object sender, EventArgs e)
        {
            txtPort.Text = "8080";

        }

        private void lsvMsg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
