using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Lab2_19521523
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            textBox1.Text = ofd.SafeFileName.ToString();
            textBox3.Text = fs.Name.ToString();
            // Count number of character in a file //
            int charCount = content.Length;
            textBox5.Text = charCount.ToString();
            // Count number of line in a file
            content = content.Replace("\r\n", "\r");
            int lineCount = richTextBox1.Lines.Count();
            content = content.Replace('\r', ' ');
            textBox2.Text = lineCount.ToString();
            // Count number of word in a file //
            string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';',':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = source.Count();
            textBox4.Text = wordCount.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
