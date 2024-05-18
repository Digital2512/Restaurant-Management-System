using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IOOP_Assignment
{
    public partial class ChefProfileForm : Form
    {
        private string username;
        private string fieldToEdit;

        public ChefProfileForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadChefProfile(username);
        }

        private void ToggleEditMode(string field, bool editMode)
        {
            // Hide all labels and textboxes initially
            lblPassword.Visible = !editMode;
            lblUsername.Visible = !editMode;
            lblGender.Visible = !editMode;
            lblBirthday.Visible = !editMode;

            txtPassword.Visible = false;
            txtName.Visible = false;
            txtGender.Visible = false;
            txtBirthday.Visible = false;

            // Show the specific textbox and label based on the field
            switch (field)
            {
                case "Password":
                    lblPassword.Visible = !editMode;
                    txtPassword.Visible = editMode;
                    lblBirthday.Visible = true;
                    lblGender.Visible = true;
                    lblUsername.Visible = true;
                    if (editMode) txtPassword.Text = lblPassword.Text;
                    break;
                case "Username":
                    lblUsername.Visible = !editMode;
                    txtName.Visible = editMode;
                    lblBirthday.Visible = true;
                    lblGender.Visible = true;
                    lblPassword.Visible = true;
                    if (editMode) txtName.Text = lblUsername.Text;
                    break;
                case "Gender":
                    lblGender.Visible = !editMode;
                    txtGender.Visible = editMode;
                    lblBirthday.Visible = true;
                    lblUsername.Visible = true;
                    lblPassword.Visible = true;
                    if (editMode) txtGender.Text = lblGender.Text;
                    break;
                case "Birthday":
                    lblBirthday.Visible = !editMode;
                    txtBirthday.Visible = editMode;
                    lblPassword.Visible = true;
                    lblGender.Visible = true;
                    lblUsername.Visible = true;
                    if (editMode) txtBirthday.Text = lblBirthday.Text;
                    break;
            }

            fieldToEdit = field;
        }

        private void BtnPassword_Click(object sender, EventArgs e)
        {
            ToggleEditMode("Password", true);
        }

        private void BtnUsername_Click(object sender, EventArgs e)
        {
            ToggleEditMode("Username", true);
        }

        private void BtnGender_Click(object sender, EventArgs e)
        {
            ToggleEditMode("Gender", true);
        }

        private void BtnBirthday_Click(object sender, EventArgs e)
        {
            ToggleEditMode("Birthday", true);
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update?", "Confirm Update", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UpdateChefProfile();
                ToggleEditMode(fieldToEdit, false);
            }
        }

        private void ButtonProfileCancel_Click(object sender, EventArgs e)
        {
            ToggleEditMode(fieldToEdit, false);
        }



        private void LoadChefProfile(string userID)
        {
            txtPassword.Visible = false;
            txtName.Visible = false;
            txtGender.Visible = false;
            txtBirthday.Visible = false;
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
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
            }
        }

        private void UpdateChefProfile()
        {
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = "";

            switch (fieldToEdit)
            {
                case "Password":
                    query = "UPDATE Users SET Password = @Value WHERE UserID = @UserID";
                    break;
                case "Username":
                    query = "UPDATE Users SET FullName = @Value WHERE UserID = @UserID";
                    break;
                case "Gender":
                    query = "UPDATE Users SET Gender = @Value WHERE UserID = @UserID";
                    break;
                case "Birthday":
                    query = "UPDATE Users SET Birthday = @Value WHERE UserID = @UserID";
                    break;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", username);
                        command.Parameters.AddWithValue("@Value", GetEditedValue());

                        command.ExecuteNonQuery();
                        MessageBox.Show("Profile updated successfully.");
                        LoadChefProfile(username);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private string GetEditedValue()
        {
            switch (fieldToEdit)
            {
                case "Password":
                    return txtPassword.Text;
                case "Username":
                    return txtName.Text;
                case "Gender":
                    return txtGender.Text;
                case "Birthday":
                    return txtBirthday.Text;
                default:
                    return "";
            }
        }

        
    }
}
