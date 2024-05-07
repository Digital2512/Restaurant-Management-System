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
    public partial class ManageUsers : Form
    
    {
        public string connectionString = "Data Source=DESKTOP-SHIU3PM;Initial Catalog = IOOPDatabase; Integrated Security = True";
        
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHomePage pg = new AdminHomePage();
            this.Hide();
            pg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnChef_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Users values (@UserID,@Password,@Role,@FullName,@Gender,@Birthday)", connection);
            cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Role", lstRole.SelectedItem);
            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
            cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Text);
            cmd.Parameters.AddWithValue("@Gender", lstGender.SelectedItem);
            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Successful Add");
        }

        private void btnUdpate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update Users set UserID = @UserID, Password = @Password, Role = @Role, FullName = @FullName, Gender = @Gender, Birthday = @Birthday", connection);
            cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Role", lstRole.SelectedItem);
            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
            cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Text);
            cmd.Parameters.AddWithValue("@Gender", lstGender.SelectedItem);
            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Successful Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete Users where UserID = @UserID", connection);
            cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Successful Deleted");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtPassword.Clear();
            lstRole.ClearSelected();
            txtFullName.Clear();
            dtpBirthday.ResetText();
            lstGender.ClearSelected();
            txtUserID.Focus();
        }
    }
}
