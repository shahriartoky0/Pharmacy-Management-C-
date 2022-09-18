using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PMS
{
    public partial class MedicineForm : Form
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
        }

        public object GetScaler(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteScalar();
        }


        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();
        }
        public MedicineForm()
        {
            InitializeComponent();

            string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

            connection = new SqlConnection(connectionString);
            connection.Open();

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var tsql = @"INSERT INTO Medicine (MedId, MedName, MedPrice, MedQuantity) 
            VALUES (@id, @name, @price, @quantity)";

            using (var cmd = new SqlCommand(tsql, connection))
            {
                try
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = MedId.Text;
                    cmd.Parameters.Add("@name", SqlDbType.Text).Value = MedName.Text;
                    cmd.Parameters.Add("@price", SqlDbType.Text).Value = MedPrice.Text;
                    cmd.Parameters.Add("@quantity", SqlDbType.Text).Value = MedQuantity.Text;

                    cmd.ExecuteNonQuery();
                  
                    MessageBox.Show("Successfully Inserted .");
                    MedId.Text = "";
                    MedName.Text = "";
                    MedPrice.Text = "";
                    MedQuantity.Text = "";
                }
                catch (Exception ex)
                {
                   
                   MessageBox.Show( ex.GetType() + ": The Value was not in a valid format "); 
                }

            }

          
            //To load the database

            string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

            connection = new SqlConnection(connectionString);
            connection.Open();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Medicine", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                MedDataGridView.DataSource = dtbl;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

            string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

            connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    for (int item = 0; item <= MedDataGridView.Rows.Count - 1; item++)
                    {
                        SqlCommand cmd6 = new SqlCommand("UPDATE Medicine SET  MedName=@MedName,MedPrice=@MedPrice, MedQuantity=@MedQuantity WHERE MedId=@MedId", sqlCon);


                        cmd6.Parameters.AddWithValue("@MedName", MedDataGridView.Rows[item].Cells[1].Value);
                        cmd6.Parameters.AddWithValue("@MedPrice", MedDataGridView.Rows[item].Cells[2].Value);
                        cmd6.Parameters.AddWithValue("@MedQuantity", MedDataGridView.Rows[item].Cells[3].Value);
                        cmd6.Parameters.AddWithValue("MedId", MedDataGridView.Rows[item].Cells[0].Value);

                        sqlCon.Open();
                        cmd6.ExecuteNonQuery();
                        sqlCon.Close();



                    }
                    MessageBox.Show("Rows Updated successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ": Make sure you inserted the appropiate value and did not leave the fields empty !");
            }

        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {

            string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

            connection = new SqlConnection(connectionString);
            connection.Open();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Medicine", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                MedDataGridView.DataSource = dtbl;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

            connection = new SqlConnection(connectionString);
            connection.Open();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Medicine", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                MedDataGridView.DataSource = dtbl;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

            connection = new SqlConnection(connectionString);
            connection.Open();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand cmd7 = new SqlCommand("DELETE FROM Medicine WHERE MedId =" + dlt_mid.Text, sqlCon);
                sqlCon.Open();
                cmd7.Parameters.AddWithValue("@EmployeeId", 0);
                cmd7.ExecuteNonQuery();
                sqlCon.Close();
                dlt_mid.Text = "";
                MessageBox.Show("Record Deleted Successfully!");
                //Restore the Data base 
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Medicine", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                MedDataGridView.DataSource = dtbl;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            content con = new content();
            con.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splash splash = new Splash();
            splash.ShowDialog();
        }

        private void MedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MedId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MedPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MedQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void MedQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MedId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}