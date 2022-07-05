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

namespace Telent_TCP
{
    public partial class Server1 : Form
    {
        public Server1()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafe_Thread));
            // serverThread.IsBackground = true;
            serverThread.Start();
        }
        Socket listenerSocket;
        IPEndPoint ipeServer;

        void StartUnsafe_Thread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipeServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);

            listenerSocket.Bind(ipeServer);
            try
            {
                listenerSocket.Listen(2);
                clientSocket = listenerSocket.Accept();
                lsvMsg.Items.Add(new ListViewItem("Server running on 127.0.0.1 9999"));
                lsvMsg.Items.Add(new ListViewItem("New client connected\n"));
                while (clientSocket.Connected)
                {

                    /*Thread receive = new Thread(Receive);
                    receive.IsBackground = true;
                    receive.Start(clientSocket);*/
                    Receive(clientSocket);

                }
                listenerSocket.Close();
            }
            catch
            {
                 listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                 ipeServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            }
            

        }
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try // nếu vượt qua ngưỡng lắng nghe
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 50];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                   lsvMsg.Items.Add(new ListViewItem(message));
                }
            }
            catch // đóng kết nối lại
            {
                client.Close();
            }

        }
        object Deserialize(byte[] data) // truyền vào mảng byte gom các mảnh thành một đối tượng
        {
            MemoryStream steam = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(steam);
        }
    }
}
