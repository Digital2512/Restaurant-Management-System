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

namespace IOOP_Assignment
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();

            if(connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = $"SELECT * FROM Users WHERE UserID= @Username AND Password = @Password;";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows) 
                    {
                        reader.Close();
                        string roleQuery = $"SELECT Role FROM Users WHERE UserID= @Username AND Password = @Password;";
                        cmd = new SqlCommand(roleQuery, connection);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        string role = cmd.ExecuteScalar() as string;
                        if (role != null)
                        {
                            switch (role)
                            {
                                case "Admin":
                                    MessageBox.Show("Login Successful. User's Role: Admin");
                                    AdminHomePage adminHomePage = new AdminHomePage();
                                    adminHomePage.Show();
                                    this.Hide();
                                    break;
                                case "Manager":
                                    MessageBox.Show("Login Successful. User's Role: Manager");
                                    ManagerHomePage managerHomePage = new ManagerHomePage();
                                    managerHomePage.Show();
                                    break;
                                case "Chef":
                                    MessageBox.Show("Login Successful. User's Role: Chef");
                                    ChefHomePage chefHomePage = new ChefHomePage();
                                    chefHomePage.Show();
                                    break;
                                case "Customer":
                                    MessageBox.Show("Login Successful. User's Role: Customer");
                                    CustomerHomePage customerHomePage = new CustomerHomePage();
                                    customerHomePage.Show();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Role not found");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Login Unsuccessful");
                    }
                        reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occured: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Connection Unsuccessful");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

