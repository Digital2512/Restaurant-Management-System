using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class productButton : UserControl
    {
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";

        private string ProductID { get; set; }
        public string UserID;
        public productButton(string userID, string productID,string productName, string productPrice, string productDescription, Image productImage)
        {
            InitializeComponent();
            this.UserID = userID;
            this.lblProductID.Text = productID;
            this.lblProductName.Text = productName;
            this.lblProductPrice.Text = productPrice;
            this.lblProductDescription.Text = productDescription;
            this.productImagePBox.Image = productImage;
            ProductID = productID;
                
        }
        private void foodButton_Load(object sender, EventArgs e)
        {

        }

        private void productImagePBox_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Database database = new Database(connectionString);
                string query = $"UPDATE Menu SET Chosen = 'TRUE' WHERE ProductID = '{ProductID}'";
                database.insertOrUpdateValuesIntoDatabase(query);

                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close();
                }

                CustomerIndividualProductPage customerIndividualProductView = new CustomerIndividualProductPage(UserID, "", 1);
                customerIndividualProductView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
