using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{ 
    public partial class CustomerProfilePage : Form
    {
        //change the connection string when using a different laptop to connect to the database
        public string ConnectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public string UserID;
        public string password;
        public CustomerProfilePage(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            Database database = new Database(ConnectionString);
            lblUserID.Text = UserID;

            string query = $"SELECT FullName FROM Users WHERE UserID = '{UserID}';";
            lblFullName.Text = database.getString(query);

            query = $"SELECT Password FROM Users WHERE UserID = '{UserID}';";
            password = database.getString(query);
            lblPasswordValue.Text = "********";

            query = $"SELECT Birthday FROM Users WHERE UserID = '{UserID}';";
            string birthdayDateTimeString = database.getDateTime(query).ToShortDateString();
            lblBirthday.Text = birthdayDateTimeString == DateTime.MinValue.ToString() ? DateTime.Now.ToString() : birthdayDateTimeString;

            query = $"SELECT CustomerID FROM Customer WHERE UserID = '{UserID}'";
            lblCustomerID.Text = database.getString(query);

            query = $"SELECT Gender FROM Users WHERE UserID = '{UserID}';";
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
                ratherNotSayRBtn.Checked = true;
            }

            query = $"SELECT ProfileImage FROM Users WHERE UserID = '{UserID}';";
            profilePBox.Image = database.getImage(query);

            maleRBtn.Enabled = false;
            femaleRBtn.Enabled = false;
            ratherNotSayRBtn.Enabled = false;

            passwordShowBtn.Image = Properties.Resources.passwordHideIcon;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CustomerUpdateProfilePage customerUpdateProfilePage = new CustomerUpdateProfilePage(UserID);
            customerUpdateProfilePage.Visible = true;
        }

        private void passwordShowBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(ConnectionString);
            if (lblPasswordValue.Text == "********")
            {
                lblPasswordValue.Text = password;
                passwordShowBtn.Image = Properties.Resources.passwordShowIcon;
            }
            else if (lblPasswordValue.Text != "********")
            {
                lblPasswordValue.Text = "********";
                passwordShowBtn.Image = Properties.Resources.passwordHideIcon;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHomePage customerHomePage = new CustomerHomePage(UserID);
            customerHomePage.Show();
        }
    }
}

