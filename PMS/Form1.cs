using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text.ToUpper() == "ADMIN" && password.Text == "ADMIN" || username.Text.ToUpper() == "SELLER" && password.Text == "SELLER" || username.Text.ToUpper() == "MANAGER" && password.Text == "MANAGER")
            {
                this.Hide();
                content con= new content();
                con.ShowDialog();
            }
          
            else
            {
                username.Text = "";
                password.Text = "";
                MessageBox.Show(" Invalid UserName or PassWord ");
            }
        }
    }
}
