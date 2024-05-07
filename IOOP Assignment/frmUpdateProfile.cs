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
    public partial class frmUpdateProfile : Form
    {
        public frmUpdateProfile()
        {
            InitializeComponent();
        }

        
        
        private void btnEditPro_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Users set @Password, @FullName, @Gender, @Birthday)", con);
            cmd.Parameters.AddWithValue("@Password", txtPsw.Text);
            cmd.Parameters.AddWithValue("@FullName", txtName.Text);
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@Birthday", txtDOB.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Profile Updated Successfully!");
            

        }
    }
}
