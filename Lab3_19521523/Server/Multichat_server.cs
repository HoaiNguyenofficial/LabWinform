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

namespace Server
{
    public partial class Multichat_server : Form
    {
        public Multichat_server()
        {
            InitializeComponent();
            Connect();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            
        }

        Socket listenerSocket;
        IPEndPoint ipeServer;
        List<Socket> ClientList; // danh sách các client đang kết nối với server


        void Connect()
        {
            ClientList = new List<Socket>();

            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipeServer = new IPEndPoint(IPAddress.Any, 10000);

            listenerSocket.Bind(ipeServer);
            lsvMessage.Items.Add(new ListViewItem("Server running on 127.0.0.1: 10000"));
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        listenerSocket.Listen(100);
                        Socket client = listenerSocket.Accept();
                        ClientList.Add(client);
                        lsvMessage.Items.Add(new ListViewItem("New client connected " + client.RemoteEndPoint));

                        Thread recv = new Thread(Receive);
                        recv.IsBackground = true;
                        recv.Start(client);
                    }
                }
                catch
                {
                    listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    ipeServer = new IPEndPoint(IPAddress.Any, 10000);
                }
                
                

            });
            Listen.IsBackground = true;
            Listen.Start();
         
        }

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try // nếu vượt qua ngưỡng lắng nghe
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 500];
                    client.Receive(data);
                    string message = (string)Deserialize(data);

                    // Gửi cho các client msg vừa nhận
                    foreach (Socket item in ClientList)
                    {
                        if(item!=null && item!= client)
                             item.Send(Serialize(message));
                    }    

                    lsvMessage.Items.Add(new ListViewItem(message));
                }
            }
            catch // đóng kết nối lại
            {
                ClientList.Remove(client);
                client.Close();
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

        private void Multichat_server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
