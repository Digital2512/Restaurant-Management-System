﻿using System;
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
        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True;";
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string username = txtUsername.Text.ToString();
            string password = passwordMTxtBox.Text.ToString();

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
                                case "ADMIN":
                                    loginButton.BackColor = Color.LimeGreen;
                                    loginButton.Text = " ٩(◕‿◕)۶";
                                    MessageBox.Show("Login Successful. User's Role: Admin");
                                    string loggedInUpdateQuery = $"UPDATE Users SET LoggedIn = 'TRUE' WHERE UserID = @username;";
                                    cmd = new SqlCommand(loggedInUpdateQuery, connection);
                                    cmd.Parameters.AddWithValue("@Username", username);
                                    cmd.ExecuteNonQuery();

                                    this.Hide();
                                    AdminHomePage adminHomePage = new AdminHomePage();
                                    adminHomePage.Show();
                                    break;
                                case "MANAGER":
                                    loginButton.BackColor = Color.LimeGreen;
                                    loginButton.Text = " ٩(◕‿◕)۶";
                                    MessageBox.Show("Login Successful. User's Role: Manager");
                                    loggedInUpdateQuery = $"UPDATE Users SET LoggedIn = 'TRUE' WHERE UserID = @username;";
                                    cmd = new SqlCommand(loggedInUpdateQuery, connection);
                                    cmd.Parameters.AddWithValue("@Username", username);
                                    cmd.ExecuteNonQuery();

                                    this.Hide();
                                    ManagerHomePage managerHomePage = new ManagerHomePage();
                                    managerHomePage.Show();
                                    break;
                                case "CHEF":
                                    loginButton.BackColor = Color.LimeGreen;
                                    loginButton.Text = " ٩(◕‿◕)۶";
                                    MessageBox.Show("Login Successful. User's Role: Chef");
                                    loggedInUpdateQuery = $"UPDATE Users SET LoggedIn = 'TRUE' WHERE UserID = @username;";
                                    cmd = new SqlCommand(loggedInUpdateQuery, connection);
                                    cmd.Parameters.AddWithValue("@Username", username);
                                    cmd.ExecuteNonQuery();

                                    this.Hide();
                                    ChefHomePage chefHomePage = new ChefHomePage(username);
                                    chefHomePage.Show();
                                    
                                    break;
                                case "CUSTOMER":
                                    loginButton.BackColor = Color.LimeGreen;
                                    loginButton.Text = " ٩(◕‿◕)۶";
                                    MessageBox.Show("Login Successful. User's Role: Customer");
                                    loggedInUpdateQuery = $"UPDATE Users SET LoggedIn = 'TRUE' WHERE UserID = @username;";

                                    string loggedInUpdateCustomerQuery = $"UPDATE Customer SET LoggedIn = 'TRUE' WHERE UserID = @username;";
                                    cmd = new SqlCommand(loggedInUpdateQuery, connection);
                                    SqlCommand secondcmd = new SqlCommand(loggedInUpdateCustomerQuery, connection);
                                    cmd.Parameters.AddWithValue("@Username", username);
                                    cmd.ExecuteNonQuery();
                                    secondcmd.Parameters.AddWithValue("@Username", username);
                                    secondcmd.ExecuteNonQuery();

                                    this.Hide();
                                    CustomerHomePage customerHomePage = new CustomerHomePage(username);
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

        private void forgotPasswordLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Database database = new Database(connectionString);
            string username = txtUsername.Text;
            string query = $"SELECT UserID FROM Users WHERE UserID = '{username}';";
            if (database.getString(query) == username)
            {
                query = $"UPDATE Users SET Password = 'Test123' WHERE UserID = '{username}';";
                if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                {
                    MessageBox.Show("Password reseted back to Default Password");
                }
                else
                {
                    MessageBox.Show("Password reset failed");
                }
            }else if(database.getString(query) != username)
            {
                MessageBox.Show("Username not found");
            }
            else
            {
                MessageBox.Show("An Error Occured");
            }
            /*
            else if (database.insertOrUpdateValuesIntoDatabase(query) == false)
            {
                MessageBox.Show("Username not found or not filled");
            }
            else
            {
                MessageBox.Show("An error occured");
            }*/
        }
    }
}

