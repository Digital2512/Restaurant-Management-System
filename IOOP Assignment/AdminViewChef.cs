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

namespace IOOP_Assignment
{
    public partial class AdminViewChef : Form
    {
        private Chef chef;
        private SqlConnection con;
        public AdminViewChef()
        {
            InitializeComponent();
            string conectionString = "Data Source=DESKTOP-SHIU3PM;Initial Catalog=IOOPDatabase;Integrated Security=True";
            con = new SqlConnection(conectionString);
            chef = new Chef(conectionString);
        }

        private void FillData(string chefId = null)
        {
            con.Open();
            string query;

            if (string.IsNullOrEmpty(chefId))
            {
                query = "Select * from chef";
            }
            else
            {
                query = "Select * from chef where Id = @ChefId";
            }

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            if (!string.IsNullOrEmpty(chefId))
            {
                da.SelectCommand.Parameters.AddWithValue("@ChefId", chefId);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvViewChef.DataSource = dt;
            con.Close();
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
            string selectedChedId = cmbChefID.SelectedItem?.ToString();
            FillData(selectedChedId);
        }

        private void AdminViewChef_Load(object sender, EventArgs e)
        {
            FillData();
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
