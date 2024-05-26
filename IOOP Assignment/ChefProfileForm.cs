using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            lblPassword.Visible = !editMode;
            lblUsername.Visible = !editMode;
            lblGender.Visible = !editMode;
            lblBirthday.Visible = !editMode;

            txtPassword.Visible = false;
            txtName.Visible = false;
            txtGender.Visible = false;
            txtBirthday.Visible = false;

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
            if (Utility.ShowConfirmationDialog("Are you sure you want to update?"))
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

            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlParameter[] parameters = { new SqlParameter("@UserID", userID) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                lblUserID.Text = row["UserID"].ToString().Trim();
                lblUsername.Text = row["FullName"].ToString().Trim();
                lblRole.Text = row["Role"].ToString().Trim();
                lblPassword.Text = row["Password"].ToString().Trim();
                lblGender.Text = row["Gender"].ToString().Trim();
                lblBirthday.Text = row["Birthday"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("UserID not found.");
            }
        }

        private void UpdateChefProfile()
        {
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

            SqlParameter[] parameters = {
                new SqlParameter("@UserID", username),
                new SqlParameter("@Value", GetEditedValue())
            };

            Utility.ExecuteSqlCommand(query, parameters);
            MessageBox.Show("Profile updated successfully.");
            LoadChefProfile(username);
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
