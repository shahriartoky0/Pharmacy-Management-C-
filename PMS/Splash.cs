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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            MyProgress.Increment(5);
            if (MyProgress.Value == 100)
            {
                this.Hide();
                Form1 log = new Form1();
                log.Show();
                timer1.Enabled = false;

            }

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
