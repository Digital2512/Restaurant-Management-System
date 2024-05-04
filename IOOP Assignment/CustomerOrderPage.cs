using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class CustomerOrderPage : Form
    {
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public CustomerOrderPage()
        {
            InitializeComponent();
            Database database = new Database(connectionString);
            string query = "SELECT ProductID, Name, Price, Description, ImageDescription FROM Menu";
            DataTable foodsData = database.getDataTable(query);


            foreach (DataRow row in foodsData.Rows)
            {
                string productID = row["ProductID"].ToString();
                string productName = row["Name"].ToString();
                string productPrice = row["Price"].ToString();
                string productDescription = row["Description"].ToString();
                string productImageDescription = row["ImageDescription"].ToString();

                Image productImage = null;

                if (!string.IsNullOrEmpty(productImageDescription))
                {
                    switch (productImageDescription)
                    {
                        case "Burger":
                            productImage = Properties.Resources.burgerImage;
                            break;
                        case "Salad":
                            productImage = Properties.Resources.saladImage;
                            break;
                        case "Pizza":
                            productImage = Properties.Resources.pizzaImage;
                            break;
                        case "Smoothie":
                            productImage = Properties.Resources.smoothieImage;
                            break;
                        case "Pasta":
                            productImage = Properties.Resources.pastaImage;
                            break;
                    }
                }

                var productButton = new foodButton(productID, productName, productPrice, productDescription, productImage);

                productDisplayFlowPanel.Controls.Add(productButton);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
