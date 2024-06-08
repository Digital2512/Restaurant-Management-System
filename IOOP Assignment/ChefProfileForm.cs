using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            InitializeGenderCheckBoxes();
            BtnUpdate.Enabled = false;
            ButtonProfileCancel.Enabled = false;
        }

        private void InitializeGenderCheckBoxes()
        {
            checkBoxMale.CheckedChanged += CheckBoxMale_CheckedChanged;
            checkBoxFemale.CheckedChanged += CheckBoxFemale_CheckedChanged;
        }

        private void CheckBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked)
            {
                checkBoxFemale.Checked = false;
            }
        }

        private void CheckBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked)
            {
                checkBoxMale.Checked = false;
            }
        }

        private void ToggleEditMode(string field, bool editMode)
        {
            lblPassword.Visible = !editMode;
            lblUsername.Visible = !editMode;
            lblGender.Visible = !editMode;
            lblBirthday.Visible = !editMode;

            txtPassword.Visible = false;
            txtName.Visible = false;
            checkBoxMale.Visible = false;
            checkBoxFemale.Visible = false;
            monthCalendarBirthday.Visible = false;

            BtnPassword.Enabled = !editMode;
            BtnUsername.Enabled = !editMode;
            BtnGender.Enabled = !editMode;
            BtnBirthday.Enabled = !editMode;
            BtnProfilePicture.Enabled = !editMode;
            BtnUpdate.Enabled = editMode;
            ButtonProfileCancel.Enabled = editMode;

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
                    checkBoxMale.Visible = editMode;
                    checkBoxFemale.Visible = editMode;
                    lblBirthday.Visible = true;
                    lblUsername.Visible = true;
                    lblPassword.Visible = true;
                    if (editMode)
                    {
                        if (lblGender.Text == "Male")
                        {
                            checkBoxMale.Checked = true;
                            checkBoxFemale.Checked = false;
                        }
                        else
                        {
                            checkBoxMale.Checked = false;
                            checkBoxFemale.Checked = true;
                        }
                    }
                    break;
                case "Birthday":
                    lblBirthday.Visible = !editMode;
                    monthCalendarBirthday.Visible = editMode;
                    lblPassword.Visible = true;
                    lblGender.Visible = true;
                    lblUsername.Visible = true;
                    if (editMode)
                    {
                        if (DateTime.TryParse(lblBirthday.Text, out DateTime parsedDate))
                        {
                            monthCalendarBirthday.SetDate(parsedDate);
                        }
                        else
                        {
                            monthCalendarBirthday.SetDate(DateTime.Today);
                        }
                    }
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
            string updatedValue = GetEditedValue();
            string message = $"Are you sure you want to update the {fieldToEdit} to {updatedValue}?";

            if (Utility.ShowConfirmationDialog(message))
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
            checkBoxMale.Visible = false;
            checkBoxFemale.Visible = false;
            monthCalendarBirthday.Visible = false;

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

                if (row["Birthday"] != DBNull.Value && DateTime.TryParse(row["Birthday"].ToString(), out DateTime parsedDate))
                {
                    lblBirthday.Text = parsedDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    lblBirthday.Text = "NULL";
                }

                if (row["ProfileImage"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["ProfileImage"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
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
                    return checkBoxMale.Checked ? "Male" : "Female";
                case "Birthday":
                    return monthCalendarBirthday.SelectionRange.Start.ToString("yyyy-MM-dd");
                default:
                    return "";
            }
        }

        private void BtnProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PictureFolder"),
                Title = "Select Profile Picture",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);

                byte[] imageBytes = File.ReadAllBytes(imagePath);
                UpdateProfilePicture(imageBytes);
            }
        }

        private void UpdateProfilePicture(byte[] imageBytes)
        {
            string query = "UPDATE Users SET ProfileImage = @ProfileImage WHERE UserID = @UserID";
            SqlParameter[] parameters = {
                new SqlParameter("@ProfileImage", imageBytes),
                new SqlParameter("@UserID", username)
            };

            Utility.ExecuteSqlCommand(query, parameters);
            MessageBox.Show("Profile picture updated successfully.");
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new ChefHomePage(username));
        }

        private void ChefProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
