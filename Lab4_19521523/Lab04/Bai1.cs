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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            string response = getHTML(url);
            txtInfo.Text = response;
        }

        public string getHTML(string szURL)
        {
            //create a request for the URL 
            WebRequest request = WebRequest.Create(szURL);
            // get the response
            WebResponse response = request.GetResponse();
            // get the streamcontaining content returned by the server 
            Stream dataStream = response.GetResponseStream();
            // open the stream using a StreamReader for easy acces
            StreamReader reader = new StreamReader(dataStream);
            // read the content
            string responeFromServer = reader.ReadToEnd();
            response.Close();
            return responeFromServer;
        }
    }
}
