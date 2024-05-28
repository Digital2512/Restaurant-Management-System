using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial_2
{
    public partial class AdminUpdateDeleteChef : Form
    {
        private Chef chef;

        public AdminUpdateDeleteChef()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
            chef = new Chef(connectionString);
        }

        private void lblUpdateDeleteChef_Click(object sender, EventArgs e)
        {

        }

        private void FillComboSearchCode()
        {
            cmbChefID.Items.Clear();
            DataTable dt = chef.GetChefId();

            foreach (DataRow dr in dt.Rows)
            {
                cmbChefID.Items.Add(dr["Id"].ToString());

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = chef.GetChefById(cmbChefID.Text);

            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtFullName.Text = row["fullName"].ToString();
                dtpDob.Value = DateTime.Parse(row["dateOfBirth"].ToString());

                string gender = row["Gender"].ToString();
                if(gender =="Male")
                {
                    rdbtnMale.Checked = true;

                }
                else if(gender =="Female")
                {
                    rdbtnFemale.Checked = true;
                }

                txtPhoneNumber.Text = row["phoneNumber"].ToString();
                txtEmail.Text = row["Email"].ToString() ;

                string chefPositions = row["chefPositions"].ToString();
                lstchefPosition.SelectedItem = chefPositions;

                string skills = row["Skills"].ToString();
                SetSkillsCheckBoxes(skills);
            }
        }

        private void SetSkillsCheckBoxes(string skills)
        {
            string[] selectedSkills = skills.Split(',');
            foreach (string s in selectedSkills)
            {
                switch(s.Trim())
                {
                    case "Knife Skills":
                        checkBox1.Checked = true; 
                        break;
                    case "Cookig Techniques":
                        checkBox2.Checked = true;
                        break;
                    case "Recipe Development":
                        checkBox3.Checked = true;
                        break;
                    case "Ingredient Knowledge":
                        checkBox4.Checked = true;
                        break;
                    case "Plating Skills":
                        checkBox5.Checked = true;
                        break;
                    default:
                        break;

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedSkills = GetSelectedSkills();
            string status = chef.updateChef(
                cmbChefID.Text,
                txtFullName.Text,
                dtpDob.Text,
                grpboxGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text,
                txtPhoneNumber.Text,
                txtEmail.Text,
                lstchefPosition.SelectedItem?.ToString(),
                selectedSkills);

            MessageBox.Show(status);
        }

        private string GetSelectedSkills()
        {
            List<string> selectedSkills = new List<string>();

            foreach(CheckBox chk in grpboxSkills.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                {
                    selectedSkills.Add(chk.Text.Trim());
                }
            }
            return string.Join(",", selectedSkills);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = cmbChefID.Text;
            string status = chef.deleteChef(id);
            MessageBox.Show(status);

            FillComboSearchCode(); //refresh combo box
            ClearForm();
        }

        private void ClearForm()
        {
            cmbChefID.Text = string.Empty;
            txtFullName.Text = string.Empty;
            dtpDob.Text = string.Empty;
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            lstchefPosition.SelectedItem = null;
            foreach(CheckBox check in grpboxSkills.Controls.OfType<CheckBox>())
            {
                check.Checked = false;
            }

        }

        private void AdminUpdateDeleteChef_Load(object sender, EventArgs e)
        {
            FillComboSearchCode();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminManageUsers mu = new AdminManageUsers();
            this.Hide();
            mu.Show();
        }
    }
}
