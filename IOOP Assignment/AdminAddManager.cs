using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace IOOP_Assignment
{
    public partial class AdminAddManager : Form
    {
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public AdminAddManager()
        {
            InitializeComponent();
        }

        string gender = "";
        private bool CheckedGender()
        {
            if (rdbtnMale.Checked)
            {
                gender = "Male";
                return true;
            }
            else if (rdbtnFemale.Checked)
            {
                gender = "Female";
                return true;
            }
            else
            {
                return false;
            }

        }
        private string AutoNewId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(Id) FROM manager", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            // Generate the ID in the format "MXX"
            string newId = "M" + (count + 1).ToString("D2");
            return newId;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!CheckedGender())
            {
                MessageBox.Show("Choose a gender");
                return; // return to prevent further execution
            }

            string skills = string.Join(", ", grpboxSkills.Controls.OfType<CheckBox>().Where(cb => cb.Checked).Select(cb => cb.Text));

            // Ensuring the selected item in lsteducationalBackground is not null
            if (lsteducationalBackground.SelectedItem == null)
            {
                MessageBox.Show("Select an educational background");
                return; // return to prevent further execution
            }
            string educationalBackground = lsteducationalBackground.SelectedItem.ToString();

            string newId = AutoNewId();


            Manager obj1 = new Manager( newId,txtfullName.Text,dtpDob.Text,gender,txtphoneNumber.Text,txtEmail.Text,skills,educationalBackground);
            MessageBox.Show(obj1.addManager());
        }



        private void AddManager_Load(object sender, EventArgs e)
        {
            lblManagerID.Text = AutoNewId();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminManageUsers mu = new AdminManageUsers();
            this.Hide();
            mu.Show();
        }
    }
}
