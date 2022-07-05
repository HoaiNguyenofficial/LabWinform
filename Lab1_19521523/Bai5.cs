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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, sa = 1, sb = 1, s1 = 0, s2 = 0,s3=0,t=1;
            a = Int32.Parse(textBox1.Text.Trim());
            b = Int32.Parse(textBox2.Text.Trim());
            for(int i=1;i<=a;i++)
            {
                sa = sa * i;
                s1 = s1 + i;
            }    
            for(int i=1;i<=b;i++)
            {
                sb = sb * i;
                s2 = s2 + i;
            }    
            for(int i=0;i<=b;i++)
            {
                t = t * a;
                s3 += t;
            }
            if (b <= 0)
            {
                groupBox1.Text = "KẾT QUẢ" + "\n"
                   
                + "A! = " + sa.ToString() + "\n"
                + "B! = " + sb.ToString() + "\n"
                + "S1 = " + s1.ToString() + "\n"          
                + "S2 = " + s3.ToString() + "\n"
                + "Vui lòng nhập B lớn hơn 0 để tính S3";
            }
            else
                groupBox1.Text = " " + "\n"
            +"A! = " + sa.ToString() + "\n"
            + "B! = " + sb.ToString() + "\n"
            + "S1 = " + s1.ToString() + "\n"
            + "S2 = " + s2.ToString() + "\n"
            + "S3 = " + s3.ToString()
            ;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int b;
            try
            {
                b = Int32.Parse(textBox2.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Nhập số nguyên ");
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            groupBox1.ResetText();
        }
    }
}
