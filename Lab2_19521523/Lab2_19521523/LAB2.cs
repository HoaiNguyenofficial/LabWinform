using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2_19521523
{
    public partial class LAB2 : Form
    {
        public LAB2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Bai5().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Bai1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Bai2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Bai3().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Bai4().Show();
        }
    }
}
