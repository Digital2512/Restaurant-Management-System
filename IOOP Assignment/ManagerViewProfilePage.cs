using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ManagerViewProfilePage : Form
    {
        public ManagerViewProfilePage()
        {
            InitializeComponent();
        }

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";



        private void ManagerViewProfilePage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("SELECT UserID, Password, Role, FullName, Gender, Birthday FROM [User] WHERE LoggedIn = 'TRUE'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblUserID.Text = "User ID: " + row["UserID"].ToString();
                lblPsw.Text = "Password: " + row["Password"].ToString();
                lblRole.Text = "Role: " + row["Role"].ToString();
                lblName.Text = "Name: " + row["FullName"].ToString();
                lblGender.Text = "Gender: " + row["Gender"].ToString();
                lblBirthday.Text = "Birthday: " + ((DateTime)row["Birthday"]).ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            ManagerUpdateProfilePage frmUpdateProfile = new ManagerUpdateProfilePage(lblUserID.Text,
        lblPsw.Text,
        lblRole.Text,
        lblName.Text,
        lblGender.Text,
        lblBirthday.Text);
            frmUpdateProfile.ShowDialog();
        }
    }
    
}
