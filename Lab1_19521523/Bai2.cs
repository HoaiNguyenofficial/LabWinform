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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float num1;
            try
            {
                num1 = float.Parse(textBox1.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số !");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float num1;
            try
            {
                num1 = float.Parse(textBox2.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số !");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float num1;
            try
            {
                num1 = float.Parse(textBox3.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số !");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2,num3, min, max;
            num1 = float.Parse(textBox1.Text.Trim());
            num2 = float.Parse(textBox2.Text.Trim());
            num3 = float.Parse(textBox3.Text.Trim());
            min = num1;
            if(min > num2)
            {
                min = num2;
                if (min > num3)
                    min = num3;
            }
            else
            {
                if (min > num3)
                    min = num3;
            }    
            max = num1;
            if(max < num2)
            {
                max = num2;
                if (max < num3)
                    max = num3;
            }
            else
            {
                if (max < num3)
                    max = num3;
            }

            textBox4.Text = min.ToString();
            textBox5.Text = max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Do you want to exit?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }
    }
    }
