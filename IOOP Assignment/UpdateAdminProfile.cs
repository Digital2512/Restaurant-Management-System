using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IOOP_Assignment
{
    public partial class UpdateAdminProfile : Form
    {
        public string connectionString = "Data Source=DESKTOP-SHIU3PM;Initial Catalog = IOOPDatabase; Integrated Security = True";
        public UpdateAdminProfile()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Users values (@UserID,@Password,@Role,@FullName,@Gender,@Birthday)", connection);
            cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Role", txtRole.Text);
            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
            cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Text);
            cmd.Parameters.AddWithValue("@Gender", lstGender.SelectedItem);
            cmd.ExecuteNonQuery();
            
            connection.Close();
            MessageBox.Show("Successful Add");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminHomePage hp = new AdminHomePage();
            this.Hide();
            hp.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtPassword.Clear(); 
            txtRole.Clear();
            txtFullName.Clear();
            dtpBirthday.ResetText();
            lstGender.ClearSelected();
            txtUserID.Focus();

        }

        private void btnUdpate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update Users set UserID = @UserID, Password = @Password, Role = @Role, FullName = @FullName, Gender = @Gender, Birthday = @Birthday", connection);
            cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Role", txtRole.Text);
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
            cmd.Parameters.AddWithValue("@UserID",txtUserID.Text);
            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Successful Deleted");
        }
    }
}


