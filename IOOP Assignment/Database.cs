using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial_2
{
    internal class Database
    {
        private string connectionString;

        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string GetString(string query)
        {
            string result = string.Empty;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query,con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    result = reader[0].ToString();
                }
                con.Close();

            }
            return result;
        }

        public DateTime GetDateTime(string query)
        {
            DateTime result = DateTime.MinValue;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetDateTime(0);
                }
                con.Close();

            }
            return result;
        }

    }
}
