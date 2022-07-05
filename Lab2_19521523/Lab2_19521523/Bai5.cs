using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab2_19521523
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog my_forder = new FolderBrowserDialog();
            my_forder.ShowDialog();
            DirectoryInfo di = new DirectoryInfo(my_forder.SelectedPath);
            textBox1.Text = di.FullName.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(textBox1.Text);
            FileInfo[] arr = di.GetFiles();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Tên file", 250);
            listView1.Columns.Add("Kích thước", 100);
            listView1.Columns.Add("Đuôi mở rộng", 100);
            listView1.Columns.Add("Ngày tao", 200);

            for(int i=0; i< arr.Length;i++)
            {
                string[] content = new string[4];
                content[0] = arr[i].Name;
                content[1] = arr[i].Length.ToString();
                content[2] = arr[i].Extension;
                content[3] = arr[i].CreationTime.ToString();

                ListViewItem itm = new ListViewItem(content);
                listView1.Items.Add(itm);
            }    
        }
    }
}
