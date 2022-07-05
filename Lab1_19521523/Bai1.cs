using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_19521523
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int num1;
            try
            {
                num1 = Int32.Parse(textBox1.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            num1 = Int32.Parse(textBox1.Text.Trim());
            num2 = Int32.Parse(textBox2.Text.Trim());
            sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int num1;
            try
            {
                num1 = Int32.Parse(textBox2.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num1;
            try
            {
                num1 = Int32.Parse(textBox1.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
