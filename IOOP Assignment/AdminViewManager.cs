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
    public partial class AdminViewManager : Form
    {
        private Admin_Manager manager;
        private SqlConnection con;
        public AdminViewManager()
        {
            InitializeComponent();
            string conectionString = "";
            con = new SqlConnection(conectionString);
            manager = new Admin_Manager(conectionString);
        }

        private void AdminViewManager_Load(object sender, EventArgs e)
        {
            FillData();
            FillComboSearchCode();
        }

        private void FillData(string managerId = null)
        {
            con.Open();
            string query;

            if (string.IsNullOrEmpty(managerId))
            {
                query = "SELECT * FROM manager";
            }
            else
            {
                query = "SELECT * FROM manager WHERE Id = @ManagerId";
            }

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            if (!string.IsNullOrEmpty(managerId))
            {
                da.SelectCommand.Parameters.AddWithValue("@ManagerId", managerId);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvViewManager.DataSource = dt;
            con.Close();
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
            string selectedManagerId = cmbManagerID.SelectedItem?.ToString();
            FillData(selectedManagerId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminManageUsers mu = new AdminManageUsers();
            this.Hide();
            mu.Show();
        }
    }
}
