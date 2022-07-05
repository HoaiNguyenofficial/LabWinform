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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            //create a request using a URL that can receive a post
            WebRequest request = WebRequest.Create("http://uit.edu.vn");
            //set the method property of the request to POST
            request.Method = "POST";

            //create POST data and conver it to a byte array
            string data = txtMsg.Text;
            byte[] byteData = Encoding.UTF8.GetBytes(data);

            // set the ContentType property of the WebRequest
            request.ContentType = "application/x-www-form-urlencoded";
            // set the ContentLength property 
            request.ContentLength = byteData.Length;

            //get the request stream 
            Stream dataStream = request.GetRequestStream();
            //write the data to the request stream
            dataStream.Write(byteData, 0, byteData.Length);
            //close the Stream obj
            dataStream.Close();

            //get the response
            WebResponse response = request.GetResponse();

            //get the steam containing content returned by the server
            //the using block ensures the stream is automatically closed
            using (dataStream = response.GetResponseStream())
            {
                //open the stream using a StreamReader for easy access
                StreamReader reader = new StreamReader(dataStream);
                //Read the content
                string responseFromServer = reader.ReadToEnd();
                //display the content
                rtxtInfo.Text = responseFromServer;
            }

        }

        
    }
}
