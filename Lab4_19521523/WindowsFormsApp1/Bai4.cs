using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        string url = "https://www.google.com";
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();

           /* StreamWriter writer = File.CreateText(source);
            writer.Write(webBrowser1.DocumentText);
            writer.Close();
            Process.Start("notepad.exe", source);*/
        }
    }
}
