using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab2_19521523
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        [Serializable()]
        public class HocVien
        {
            public string MSSV;
            public string FullName;
            public string Phone;
            public double DiemToan;
            public double DiemVan;
            public double DiemTB;

            public HocVien()
            {
                MSSV = "";
                FullName = "";
                Phone = "";
                DiemToan = 0.0;
                DiemVan = 0.0;
                DiemTB = 0.0;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            HocVien hv = new HocVien();
            hv.MSSV = textBox1.Text;
            hv.FullName = textBox2.Text;
            hv.Phone = textBox3.Text;
            hv.DiemToan = float.Parse(textBox4.Text);
            hv.DiemVan = float.Parse(textBox5.Text);
            float DiemTB = (float.Parse(textBox4.Text) + float.Parse(textBox5.Text)) / 2;
            hv.DiemTB = DiemTB;
            try
            {
                FileStream fs = new FileStream("C:\\Users\\19521\\Desktop\\MCB\\Lab2_19521523\\Bai4_input.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, hv);
                fs.Close();

                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                textBox3.Text = String.Empty;
                textBox4.Text = String.Empty;
                textBox5.Text = String.Empty;

                MessageBox.Show("Thành công");
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                listView1.Items[i].Remove();

            }
            FileStream fs = new FileStream("C:\\Users\\19521\\Desktop\\MCB\\Lab2_19521523\\Bai4_input.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            HocVien hv = new HocVien();


            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("MSSV", 50);
            listView1.Columns.Add("Họ và Tên", 100);
            listView1.Columns.Add("Điểm Toán", 90);
            listView1.Columns.Add("Điểm Lý", 90);
            listView1.Columns.Add("Điểm Hóa", 90);
            listView1.Columns.Add("Điểm TB", 90);

            while (fs.Position < fs.Length)
            {
                hv = (HocVien)binaryFormatter.Deserialize(fs);
                ListViewItem Item1 = new ListViewItem();
                Item1.Text = hv.MSSV;
                Item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = hv.FullName });
                Item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = hv.Phone});
                Item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = hv.DiemToan.ToString() });
                Item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = hv.DiemVan.ToString() });
                Item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = hv.DiemTB.ToString() });
                listView1.Items.Add(Item1);
            }
            fs.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
