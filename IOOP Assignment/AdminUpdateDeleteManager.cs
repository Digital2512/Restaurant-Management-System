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

namespace IOOP_Assignment
{
    public partial class AdminUpdateDeleteManager : Form
    {
        private Manager manager;
        public AdminUpdateDeleteManager()
        {
            InitializeComponent();

            string connctionString ="Data Source=DESKTOP-SHIU3PM;Initial Catalog=IOOPDatabase;Integrated Security=True";

            manager = new Manager(connctionString);
        }

        private void FillComboSearchCode()
        {
            cmbManagerID.Items.Clear();
            DataTable dt = manager.GetManagerId();

            foreach (DataRow dr in dt.Rows)
            {
                cmbManagerID.Items.Add(dr["Id"].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = manager.GetManagerById(cmbManagerID.Text);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtfullName.Text = row["fullName"].ToString();
                dtpDob.Value = DateTime.Parse(row["dateOfBirth"].ToString());

                string gender = row["Gender"].ToString();
                if (gender == "Male")
                {
                    rdbtnMale.Checked = true;
                }
                else if (gender == "Female")
                {
                    rdbtnFemale.Checked = true;
                }
                txtphoneNumber.Text = row["phoneNumber"].ToString();
                txtEmail.Text = row["Email"].ToString();

                string educationalBackground = row["educationalBackground"].ToString();
                lsteducationalBackground.SelectedItem = educationalBackground;

                string skills = row["Skills"].ToString();
                SetSkillsCheckBoxes(skills);

            }
        }
        private void SetSkillsCheckBoxes(string skills)
        {
            string[] selectedSkills = skills.Split(',');

            foreach (string s in selectedSkills)
            {
                switch (s.Trim())
                {
                    case "Food And Beverage Knowledge":
                        checkBox1.Checked = true;
                        break;
                    case "Inventory Management":
                        checkBox2.Checked = true;
                        break;
                    case "Financial Management":
                        checkBox3.Checked = true;
                        break;
                    case "Communication skills":
                        checkBox4.Checked = true;
                        break;
                    case "Sales Techniques":
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
            string status = manager.updateManager(
                cmbManagerID.Text,
                txtfullName.Text,
                dtpDob.Text,
                grpboxGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text,
                txtphoneNumber.Text,
                txtEmail.Text,
                lsteducationalBackground.SelectedItem?.ToString(),
                selectedSkills);

            MessageBox.Show(status);
        }

        private string GetSelectedSkills()
        {
            List<string> selectedSkills = new List<string>();

            foreach (CheckBox chk in grpboxSkills.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                {
                    selectedSkills.Add(chk.Text.Trim());
                }
            }

            // Join the selected skills into a comma-separated string
            return string.Join(",", selectedSkills);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = cmbManagerID.Text;
            string status = manager.deleteManager(id);
            MessageBox.Show(status);

            FillComboSearchCode(); //refresh the combo box
            ClearForm();
        }

        private void ClearForm()
        {
            cmbManagerID.Text = string.Empty;
            txtfullName.Text = string.Empty;
            dtpDob.Text = string.Empty;
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
            txtphoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            lsteducationalBackground.SelectedItem = null;
            foreach (CheckBox check in grpboxSkills.Controls.OfType<CheckBox>())
            {
                check.Checked = false;
            }
        }

        private void AdminUpdateDeleteManager_Load(object sender, EventArgs e)
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
