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

namespace trial_2
{
    public partial class AdminAddChef : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SHIU3PM;Initial Catalog=IOOPDatabase;Integrated Security=True");

        public AdminAddChef()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            SqlCommand cmd = new SqlCommand("Select count(Id) from chef", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            string newId = "CH" + (count +1).ToString("D2");
            return newId;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(!CheckedGender())
            {
                MessageBox.Show("Choose a gender");
                return;
            }

            string skills = string.Join(",", grpboxSkills.Controls.OfType<CheckBox>().Where(cb => cb.Checked).Select(cb => cb.Text));

            if(lstchefPosition.SelectedItem == null)
            {
                MessageBox.Show("Select an chef position");
                return;
            }

            string chefPositions = lstchefPosition.SelectedItem.ToString();

            string newId = AutoNewId();

            Chef obj1 = new Chef (newId,txtfullName.Text,dtpDob.Text,gender,txtphoneNumber.Text,txtEmail.Text,skills,chefPositions);
            MessageBox.Show(obj1.addChef());
        }

        private void AdminAddChef_Load(object sender, EventArgs e)
        {
            lblChefID.Text = AutoNewId();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminManageUsers mu = new AdminManageUsers ();
            this.Hide();
            mu.Show ();
        }
    }
}
