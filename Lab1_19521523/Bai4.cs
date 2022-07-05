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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
                    }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            double num1, t = 0;
            num1 = double.Parse(textBox1.Text.Trim());
            string s = comboBox1.Text;
            switch (s)
            {
                case "USD (Đô la Mỹ)":
                    t = num1 * (22.772);
                    textBox2.Text = t.ToString();
                    label4.Text = "1 USD= 22.772 VND";
                    break;
                case "EUD(Euro)":
                    t = num1 * 28.132;
                    textBox2.Text = t.ToString();
                    label4.Text = "1 EUD= 28.132 VND";
                    break;
                case "GBP(Bảng Anh)":
                    t = num1 * 31.538;
                    textBox2.Text = t.ToString();
                    label4.Text = "1 GBP= 31.538 VND";
                    break;
                case "SGD(Tiền Singapore)":
                    t = num1 * 17.268;
                    textBox2.Text = t.ToString();
                    label4.Text = "1 SGD= 17.268 VND";
                    break;
                case "JPY(Yên Nhật)":
                    t = num1 * 214;
                    textBox2.Text = t.ToString();
                    label4.Text = "1 JYP= 214 VND";
                    break;

            }
        }
    }
}
