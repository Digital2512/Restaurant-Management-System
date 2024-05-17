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

namespace IOOP_Assignment
{
    public partial class ChefProfileForm : Form
    {
        private string username;

        public ChefProfileForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadChefProfile(username);
        }

        private void LoadChefProfile(string UserID)
        {
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                lblUserID.Text = reader["UserID"].ToString().Trim();
                                lblUsername.Text = reader["FullName"].ToString().Trim();
                                lblRole.Text = reader["Role"].ToString().Trim();
                                lblPassword.Text = reader["Password"].ToString().Trim();
                                lblGender.Text = reader["Gender"].ToString().Trim();
                                lblBirthday.Text = reader["Birthday"].ToString().Trim();
                            }
                            else
                            {
                                MessageBox.Show("UserID not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
