using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace TCP
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            txtMsg.Clear();
        }

        IPEndPoint IP;
        Socket Client_tcp;

        void Connect()
        {
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            Client_tcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                Client_tcp.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        /*    Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();*/
        }
        void Send()
        {
            if (txtMsg.Text != String.Empty)
                Client_tcp.Send(Serialize(txtMsg.Text));
        }

        byte[] Serialize(object obj)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter fomatter = new BinaryFormatter();
            fomatter.Serialize(ms, obj);
            return ms.ToArray();
        }

       
        void Close()
        {
            Client_tcp.Close();
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
