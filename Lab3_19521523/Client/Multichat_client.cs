using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Multichat_client : Form
    {
        public Multichat_client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            txtMessage.Clear();
        }

        IPEndPoint IP;
        Socket Client_tcp;

        void Connect()
        {
            //IP là địa chỉ của server
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10000);
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
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Send()
        {
            if (txtMessage.Text != String.Empty)
            {
                string text = txtName.Text + " : " + txtMessage.Text;
                Client_tcp.Send(Serialize(text));
                //lsvMessage.Items.Add(new ListViewItem( txtMessage.Text));
                lsvMessage.Items.Add(new ListViewItem() { Text = txtName.Text+" : "+ txtMessage.Text });
            }

        }
        void Receive()
        {
            try // nếu vượt qua ngưỡng lắng nghe
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 50];
                    Client_tcp.Receive(data);

                    string message = (string)Deserialize(data);
                    lsvMessage.Items.Add(new ListViewItem() { Text = message });
                }
            }
            catch // đóng kết nối lại
            {
               Close();
            }
        }
        

        byte[] Serialize(object obj)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter fomatter = new BinaryFormatter();
            fomatter.Serialize(ms, obj);
            return ms.ToArray();
        }
        object Deserialize(byte[] data) // truyền vào mảng byte gom các mảnh thành một đối tượng
        {
            MemoryStream steam = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(steam);
        }

        private void Multichat_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
