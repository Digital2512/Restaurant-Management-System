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
    public partial class CustomerUpdateProfilePage : Form
    {
        public CustomerUpdateProfilePage()
        {
            InitializeComponent();
        }

        private void lblUserIDTitle_Click(object sender, EventArgs e)
        {

        }

        private void profilePBox_Click(object sender, EventArgs e)
        {

        }

        private void fullNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        public string ConnectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(ConnectionString);
            string fullName = fullNameTxtBox.Text;
            string password = passwordMTextBox.Text;
            string confirmPassword = confirmPasswordMaskedTextBox.Text;
            string gender;
            if (maleRBtn.Checked)
            {
                gender = "MALE";
            }else if (femaleRBtn.Checked)
            {
                gender = "FEMALE";
            }else if (ratherNotSayRBtn.Checked)
            {
                gender = "RATHER NOT SAY";
            }
            else
            {
                gender = "RATHER NOT SAY";
            }
            string birthday = birthdayDateTimePicker.Text;
            string query = "UPDATE TABLE ";
            database.insertValuesIntoDatabase(query);
        }
    }
}
