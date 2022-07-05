using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string url = "https://www.google.com";
            String source = ("C:\\Users\\19521\\Desktop\\MCB\\Lab4_19521523\\bai4.txt");

            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(url);
            myClient.DownloadFile(url, source);

            WebRequest request = WebRequest.Create(url);
            // get the response
            WebResponse response2 = request.GetResponse();
            // get the streamcontaining content returned by the server 
            Stream dataStream = response2.GetResponseStream();
            // open the stream using a StreamReader for easy acces
            StreamReader reader = new StreamReader(dataStream);
            // read the content
            string responeFromServer = reader.ReadToEnd();
            response.Close();
            richTextBox1.Text = responeFromServer;
        }
    }
}
