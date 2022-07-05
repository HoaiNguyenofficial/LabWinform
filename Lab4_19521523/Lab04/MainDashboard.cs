using System;
using System.Windows.Forms;
namespace Lab04
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }


        private void btnGet_Click(object sender, EventArgs e)
        {
            new Bai1().Show();
        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            new Bai2().Show();
        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            new Bai3().Show();
        }

        public void btn4_Click(object sender, EventArgs e)
        {
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
