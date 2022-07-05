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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show(" Sai du lieu dau vao!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Int32.Parse(textBox1.Text.Trim());
            switch (num)
            {
                case 0:
                    textBox2.Text = "Zero";
                    break;
                case 1:
                    textBox2.Text = "One";
                    break;
                case 2:
                    textBox2.Text = "Two";
                    break;
                case 3:
                    textBox2.Text = "Three";
                    break;
                case 4:
                    textBox2.Text = "Four";
                    break;
                case 5:
                    textBox2.Text = "Five";
                    break;
                case 6:
                    textBox2.Text = "Six";
                    break;
                case 7:
                    textBox2.Text = "Seven";
                    break;
                case 8:
                    textBox2.Text = "Eight";
                    break;
                case 9:
                    textBox2.Text = "Nine";
                    break;
            }    
                
                    
        }
    }
}
