using IOOP_Assignment.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IOOP_Assignment
{
    public partial class frmMenu : Form
    {
        
        public frmMenu()
        {
            InitializeComponent();
        }

        

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            { 
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtProID.Text = row.Cells[0].Value.ToString();
                txtProName.Text = row.Cells[1].Value.ToString();
                txtDesc.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                txtCat.Text = row.Cells[4].Value.ToString();
              
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (openFileDialog1.ShowDialog()== DialogResult.OK) 
            {
                picProfile.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }


        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Menu values (@ProductID, @Name, @Description, @Price, @Category)", con);
            cmd.Parameters.AddWithValue("@ProductID", txtProID.Text);
            cmd.Parameters.AddWithValue("@Name", txtProName.Text);
            cmd.Parameters.AddWithValue("@Description", txtDesc.Text);
            cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@Category", txtCat.Text);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Product Added Successfully!");

        }

        private void picProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
