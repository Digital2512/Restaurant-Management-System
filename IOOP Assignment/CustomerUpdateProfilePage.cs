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
<<<<<<< HEAD
using System.IO;
=======
>>>>>>> Huey-Shin

namespace IOOP_Assignment
{
    public partial class CustomerUpdateProfilePage : Form
    {
        public string ConnectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public CustomerUpdateProfilePage()
        {
            InitializeComponent();
            Database database = new Database(ConnectionString);
            string query = "SELECT UserID FROM Users WHERE LoggedIn = 'TRUE';";
            string userID = database.getString(query);
            lblUserID.Text = userID;
            query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE'";
            string customerID = database.getString(query);
            lblCustomerID.Text = customerID;
<<<<<<< HEAD
            query = $"SELECT FullName FROM Users WHERE UserID = '{userID}';";
=======
            query = $"SELECT fullName FROM Users WHERE UserID = '{userID}';";
>>>>>>> Huey-Shin
            fullNameTxtBox.Text = database.getString(query);
            query = $"SELECT Password FROM Users WHERE UserID = '{userID}'";
            passwordMTextBox.Text = database.getString(query);
            confirmPasswordMTextBox.Text = database.getString(query);
            query = $"SELECT Birthday FROM Users WHERE UserID = '{userID}'";
<<<<<<< HEAD
            string birthdayDateTimeString = database.getDateTime(query).ToString();
            if (birthdayDateTimeString == DateTime.MinValue.ToString())
            {
                birthdayDateTimePicker.Value = DateTime.Now;
            }
            else
            {
                birthdayDateTimePicker.Value = database.getDateTime(query);
            }
=======
            birthdayDateTimePicker.Text = database.getDateTime(query).ToString();
>>>>>>> Huey-Shin
            query = $"SELECT Gender FROM Users WHERE UserID = '{userID}';";
            string gender = database.getString(query);
            if (gender == "MALE")
            {
                maleRBtn.Checked = true;
            }
            else if (gender == "FEMALE")
            {
                femaleRBtn.Checked = true;
            }
            else if (gender == "RATHER NOT SAY")
            {
                ratherNotSayRBtn.Checked = true;
            }
            else
            {
                maleRBtn.Checked = false;
                femaleRBtn.Checked = false;
                ratherNotSayRBtn.Checked = false;
            }
<<<<<<< HEAD
            query = $"SELECT ProfileImage FROM Users WHERE UserID = '{userID}';";
            profilePBox.Image = database.getImage(query);
=======
>>>>>>> Huey-Shin
        }

        private void lblUserIDTitle_Click(object sender, EventArgs e)
        {

        }

        private void profilePBox_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Database database = new Database(ConnectionString);
            string query = "SELECT UserID FROM Users WHERE LoggedIn = 'TRUE';";
            string userID = database.getString(query);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    byte[] imageData = File.ReadAllBytes(imagePath);
                    query = $"UPDATE Users SET ProfileImage = @ImageData WHERE UserID = '{userID}';";

                    if (database.insertOrUpdateImageToFile(imagePath, query) == true)
                    {
                        query = $"SELECT ProfileImage FROM Users WHERE UserID = '{userID}';";
                        profilePBox.Image = database.getImage(query);
                    }
                    else
                    {
                        MessageBox.Show("Picture not updated");
                        //profilePBox.Image = Properties.Resources.errorImage;
                    }
                }
            }
=======
>>>>>>> Huey-Shin

        }

        private void fullNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string query;
            Database database = new Database(ConnectionString);
            query = "SELECT UserID FROM Users WHERE LoggedIn = 'TRUE';";
            string userID = database.getString(query);
            string fullName = fullNameTxtBox.Text;
            string password = passwordMTextBox.Text;
            string confirmPassword = confirmPasswordMTextBox.Text;
            string birthday = birthdayDateTimePicker.Text;
            string gender = "";
            if (maleRBtn.Checked)
            {
                gender = "MALE";
            }else if (femaleRBtn.Checked)
            {
                gender = "FEMALE";
            }
            else if (ratherNotSayRBtn.Checked)
            {
                gender = "RATHER NOT SAY";
            }
            else
            {
                MessageBox.Show("Please select a gender");
            }
            if (password == confirmPassword)
            {
<<<<<<< HEAD
                query = $"UPDATE Users SET [FullName] = '{fullName}', [Gender] = '{gender}', [Birthday] = '{birthday}', [Password] = '{password}' WHERE [UserID] = '{userID}';";
                if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                {
                    MessageBox.Show("Profile updated successfully!");
                    this.Hide();
                    CustomerProfilePage customerProfilePage = new CustomerProfilePage();
                    customerProfilePage.Show();
=======
                query = $"UPDATE Users SET [fullName] = '{fullName}', [Gender] = '{gender}', [Birthday] = '{birthday}', [Password] = '{password}' WHERE [UserID] = '{userID}';";
                if (database.insertValuesIntoDatabase(query) == true)
                {
                    MessageBox.Show("Profile updated successfully!");
>>>>>>> Huey-Shin
                }
                else
                {
                    MessageBox.Show("Profile not updated");
                }
            }
            else
            {
                MessageBox.Show("Passwords does not match");
            }
        }

        private void passwordShowHideBtn_Click(object sender, EventArgs e)
        {
            if(passwordMTextBox.PasswordChar == '\0')
            {
                passwordMTextBox.PasswordChar = '*';
<<<<<<< HEAD
                //passwordShowBtn.Image = Properties.Resources.passwordShowIconResized;
=======
                passwordShowBtn.Image = Properties.Resources.passwordShowIcon;
>>>>>>> Huey-Shin
            }
            else
            {
                passwordMTextBox.PasswordChar = '\0';
<<<<<<< HEAD
                //passwordShowBtn.Image = Properties.Resources.passwordlHideIconResized;
=======
                passwordShowBtn.Image = Properties.Resources.passwordHideIcon;
>>>>>>> Huey-Shin
            }
        }

        private void confirmPasswordShowHideBtn_Click(object sender, EventArgs e)
        {
            if (passwordMTextBox.PasswordChar == '\0')
            {
                confirmPasswordMTextBox.PasswordChar = '*';
<<<<<<< HEAD
                //confirmPasswordShowHideBtn.Image = Properties.Resources.passwordShowIconResized;
=======
                confirmPasswordShowHideBtn.Image = Properties.Resources.passwordShowIcon;
>>>>>>> Huey-Shin
            }
            else
            {
                confirmPasswordMTextBox.PasswordChar = '\0';
<<<<<<< HEAD
                //confirmPasswordShowHideBtn.Image = Properties.Resources.passwordlHideIconResized;
=======
                confirmPasswordShowHideBtn.Image = Properties.Resources.passwordHideIcon;
>>>>>>> Huey-Shin
            }
        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerProfilePage customerProfilePage = new CustomerProfilePage();
            customerProfilePage.Show();
        }
=======
>>>>>>> Huey-Shin
    }
}
