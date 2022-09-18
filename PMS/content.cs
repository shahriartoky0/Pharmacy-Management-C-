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
    public partial class content : Form
    {
        public content()
        {
            InitializeComponent();
        }

        private void ConMed_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicineForm medicineForm = new MedicineForm(); 
            medicineForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicineForm medicineForm = new MedicineForm();
            medicineForm.ShowDialog();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicineForm medicineForm = new MedicineForm();
            medicineForm.ShowDialog();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompaniesForm companiesForm = new CompaniesForm();
            companiesForm.ShowDialog();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompaniesForm companiesForm = new CompaniesForm();
            companiesForm.ShowDialog();
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee employee = new Employee();
            employee.ShowDialog();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee employee = new Employee();
            employee.ShowDialog();
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splash splash = new Splash();
            splash.ShowDialog();
        }
    }
}
