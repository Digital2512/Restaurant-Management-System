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
        public string ConnectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public CustomerProfilePage()
        {
            InitializeComponent();
            Database database = new Database(ConnectionString);
            string query = "SELECT UserID FROM Users WHERE LoggedIn = 'TRUE';";
            string userID = database.getString(query);
            lblUserID.Text = userID;
            query = $"SELECT FullName FROM Users WHERE UserID = '{userID}';";
            lblFullName.Text = database.getString(query);
            query = $"SELECT Password FROM Users WHERE UserID = '{userID}';";
            lblPasswordValue.Text = database.getString(query);
            query = $"SELECT Birthday FROM Users WHERE UserID = '{userID}';";
            lblBirthday.Text = database.getDateTime(query).ToString();
            query = $"SELECT CustomerID FROM Customer WHERE UserID = '{userID}'";
            lblCustomerID.Text = database.getString(query);
            query = $"SELECT Gender FROM Users WHERE UserID = '{userID}';";
            string gender = database.getString(query);
            if (gender == "MALE")
            {
                maleRBtn.Checked = true;
            }else if(gender == "FEMALE")
            {
                femaleRBtn.Checked = true;
            }else if(gender == "RATHER NOT SAY")
            {
                ratherNotSayRBtn.Checked = true;
            }
            else
            {
                maleRBtn.Checked = false;
                femaleRBtn.Checked = false;
                ratherNotSayRBtn.Checked = false;
            }
        }

        private void CustomerProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CustomerUpdateProfilePage customerUpdateProfilePage = new CustomerUpdateProfilePage();
            customerUpdateProfilePage.Visible = true;
        }

        private void passwordShowBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(ConnectionString);
            if (lblPasswordValue.Text == "********")
            {
                string query = $"SELECT UserID FROM Users WHERE LoggedIn = 'TRUE';";
                string userID = database.getString(query);
                query = $"SELECT password FROM Users WHERE UserID = '{userID}';";
                lblPasswordValue.Text = database.getString(query);
                passwordShowBtn.Image = Properties.Resources.passwordHideIcon;
            }
            else if (lblPasswordValue.Text != "********")
            {
                lblPasswordValue.Text = "********";
                passwordShowBtn.Image = Properties.Resources.passwordShowIcon;
            }
        }
    }
}
