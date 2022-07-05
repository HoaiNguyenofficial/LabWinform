﻿using System;
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

namespace Telent_TCP
{
    public partial class TCP_telnet : Form
    {
        public TCP_telnet()
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

        void StartUnsafe_Thread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipeServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            listenerSocket.Bind(ipeServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            lsvMessage.Items.Add(new ListViewItem("Telnet running on 127.0.0.1 8080"));
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                }
                while (text[text.Length - 1] != '\n');
                lsvMessage.Items.Add(new ListViewItem(text));
            }
            listenerSocket.Close();

        }
    }
}
