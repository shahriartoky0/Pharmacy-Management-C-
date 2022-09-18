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
    public partial class Employee : Form
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
        public Employee()
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
                var tsql = @"INSERT INTO Employee (EmployeeId, EmployeeName, EmployeeAge, EmployeePhone, EmployeePassword) 
            VALUES (@id, @name, @age, @phone, @password)";

                using (var cmd = new SqlCommand(tsql, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = EmId.Text;
                    cmd.Parameters.Add("@name", SqlDbType.Text).Value = EmName.Text;
                    cmd.Parameters.Add("@age", SqlDbType.Text).Value = EmAge.Text;
                    cmd.Parameters.Add("@phone", SqlDbType.Text).Value = EmPhone.Text;
                    cmd.Parameters.Add("@password", SqlDbType.Text).Value = EmPassword.Text;
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(" Successfully Inserted.");
                EmId.Text = "";
                EmName.Text = "";
                EmAge.Text = "";
                EmPhone.Text = "";
                EmPassword.Text = "";

                string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

                connection = new SqlConnection(connectionString);
                connection.Open();

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Employee", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + "The Value was not in a valid format ");
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
                SqlDataAdapter sqlDa= new SqlDataAdapter("SELECT * FROM Employee",sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

            string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

            connection = new SqlConnection(connectionString);
            connection.Open();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Employee", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
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
                    for (int item = 0; item <= dataGridView1.Rows.Count - 1; item++)
                    {
                        SqlCommand cmd3 = new SqlCommand("UPDATE Employee SET  EmployeeName=@EmployeeName,EmployeeAge=@EmployeeAge, EmployeePhone=@EmployeePhone,EmployeePassword=@EmployeePassword WHERE EmployeeId=@EmployeeId", sqlCon);


                        cmd3.Parameters.AddWithValue("@EmployeeName", dataGridView1.Rows[item].Cells[1].Value);
                        cmd3.Parameters.AddWithValue("@EmployeeAge", dataGridView1.Rows[item].Cells[2].Value);
                        cmd3.Parameters.AddWithValue("@EmployeePhone", dataGridView1.Rows[item].Cells[3].Value);
                        cmd3.Parameters.AddWithValue("@EmployeePassword", dataGridView1.Rows[item].Cells[4].Value);
                     cmd3.Parameters.AddWithValue("EmployeeId", dataGridView1.Rows[item].Cells[0].Value);

                        sqlCon.Open();
                        cmd3.ExecuteNonQuery();
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"uid=sa;pwd=1234;
                            database=PMS;
                            server=BOSS";

            connection = new SqlConnection(connectionString);
            connection.Open();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd4 = new SqlCommand("DELETE FROM Employee WHERE EmployeeId =" + dlt_eid.Text, sqlCon);
                    sqlCon.Open();
                    cmd4.Parameters.AddWithValue("@EmployeeId", 0);
                    cmd4.ExecuteNonQuery();
                    sqlCon.Close();
                    dlt_eid.Text = "";
                    MessageBox.Show("Record Deleted Successfully!");
                    //to make the database loaded
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Employee", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType() + ": Make sure you inserted the appropiate value and did not leave the fields empty !");

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            content con =new content();
            con.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splash splash = new Splash();
            splash.ShowDialog();
        }

        private void EmId_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
