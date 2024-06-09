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
    public partial class AdminViewFeedback : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True");
        public AdminViewFeedback()
        {
            InitializeComponent();
        }

        private void FillData(string feedbackId = null)
        {
            con.Open();
            string query;

            if (string.IsNullOrEmpty(feedbackId))
            {
                query = "Select * from Feedback";
            }
            else
            {
                query = "Select * from Feedback where FeedbackID = @feedbackId";
            }

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            if (!string.IsNullOrEmpty(feedbackId))
            {
                da.SelectCommand.Parameters.AddWithValue("@feedbackId", feedbackId);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvViewFeedback.DataSource = dt;
            con.Close();
        }

        private void FillComboSearchCode()
        {
            cmbFeedbackID.Items.Clear();
            con.Open();

            SqlCommand cmd = new SqlCommand("Select FeedbackID from Feedback", con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbFeedbackID.Items.Add(dr["FeedbackID"].ToString());
            }
            con.Close();
        }

        private void AdminViewFeedback_Load(object sender, EventArgs e)
        {
            FillComboSearchCode();
            FillData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedFeedbackID = cmbFeedbackID.SelectedItem?.ToString();
            FillData(selectedFeedbackID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage hp = new AdminHomePage();
            this.Close();
            hp.ShowDialog();
        }
    }
}
