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

namespace Lab04
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //initial WebClient
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(txtURL.Text);
            myClient.DownloadFile(txtURL.Text, txtLink.Text);

            //create a request for the URL 
            WebRequest request = WebRequest.Create(txtURL.Text);
            // get the response
            WebResponse response2 = request.GetResponse();
            // get the streamcontaining content returned by the server 
            Stream dataStream = response2.GetResponseStream();
            // open the stream using a StreamReader for easy acces
            StreamReader reader = new StreamReader(dataStream);
            // read the content
            string responeFromServer = reader.ReadToEnd();
            response.Close();
            rtxtInfo.Text= responeFromServer;
        }


    }
}
