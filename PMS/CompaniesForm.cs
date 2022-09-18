using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PMS;
using System.Configuration;

namespace PMS
{
    public partial class CompaniesForm : Form
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
        public CompaniesForm()
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
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var tsql = @"INSERT INTO Companies (Comid, ComName, ComPhone, ComBill) 
            VALUES (@id, @name, @phone, @bill)";

                using (var cmd = new SqlCommand(tsql, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = ComId.Text;
                    cmd.Parameters.Add("@name", SqlDbType.Text).Value = ComName.Text;
                    cmd.Parameters.Add("@phone", SqlDbType.Text).Value = ComPhone.Text;
                    cmd.Parameters.Add("@bill", SqlDbType.Text).Value = ComBill.Text;

                    cmd.ExecuteNonQuery();
                    ComId.Text = "";
                    ComName.Text = "";
                    ComPhone.Text = "";
                    ComBill.Text = "";
                }






                MessageBox.Show("Successfully Inserted.");
                string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

                connection = new SqlConnection(connectionString);
                connection.Open();
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Companies", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    ComDGV.DataSource = dtbl;
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.GetType() + ": The Value was not in a valid format "); }


        }
        
        private void ComDGV_Load(object sender, DataGridViewCellEventArgs e)
        {
         
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Companies", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ComDGV.DataSource = dtbl;
            }
        }

        private void CompaniesForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

            connection = new SqlConnection(connectionString);
            connection.Open();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Companies", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ComDGV.DataSource = dtbl;
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
                    for (int item = 0; item <= ComDGV.Rows.Count - 1; item++)
                    {
                        SqlCommand cmd4 = new SqlCommand("UPDATE Companies SET  ComPhone=@ComPhone,ComName=@ComName, ComBill=@ComBill WHERE ComId=@ComId", sqlCon);


                        cmd4.Parameters.AddWithValue("@ComName", ComDGV.Rows[item].Cells[1].Value);
                        cmd4.Parameters.AddWithValue("@ComPhone", ComDGV.Rows[item].Cells[2].Value);
                        cmd4.Parameters.AddWithValue("@ComBill", ComDGV.Rows[item].Cells[3].Value);
                        cmd4.Parameters.AddWithValue("ComId", ComDGV.Rows[item].Cells[0].Value);

                        sqlCon.Open();
                        cmd4.ExecuteNonQuery();
                        sqlCon.Close();



                    }
                    MessageBox.Show("Rows Updated successfully");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.GetType() + ": Make sure you inserted the appropiate value and did not leave the fields empty !"); }
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
                SqlCommand cmd4 = new SqlCommand("DELETE FROM Companies WHERE ComId =" + dlt_cid.Text, sqlCon);
                sqlCon.Open();
                cmd4.Parameters.AddWithValue("@EmployeeId", 0);
                cmd4.ExecuteNonQuery();
                sqlCon.Close();
                dlt_cid.Text = "";
                MessageBox.Show("Record Deleted Successfully!");

                //to make the database loaded
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Companies", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ComDGV.DataSource = dtbl;

            }
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

        private void ComDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
