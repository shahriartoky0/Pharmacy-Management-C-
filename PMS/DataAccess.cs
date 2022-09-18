using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PMS
{
    class DataAccess : IDisposable
    {
        protected SqlConnection connection;
        protected SqlCommand command;
        public DataAccess()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PMS"].ConnectionString);
            connection.Open();
        }

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
        public void Dispose()
        {
            connection.Close();
        }
    }
}
