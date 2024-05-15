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
            string query = "SELECT ProductID, Name, Price, Description, ImageDescription, Ratings FROM Menu";
            DataTable foodsData = database.getDataTable(query);


            foreach (DataRow row in foodsData.Rows)
            {
                string productID = row["ProductID"].ToString();
                string productName = row["Name"].ToString();
                string productPrice = row["Price"].ToString();
                string productDescription = row["Description"].ToString();
                string productImageDescription = row["ImageDescription"].ToString();
                string productRatingText = row["Ratings"].ToString();

                Image productImage = null;

                if (!string.IsNullOrEmpty(productImageDescription))
                {
                    productImage = Properties.Resources.DeliciousIcon;
                }

                var productButton = new foodButton(productID, productName, productPrice, productDescription, productImage, productRatingText);

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
            productDisplayFlowPanel.Controls.Clear();
            Database database = new Database(connectionString);
            string searchString = searchTxtBox.Text;
            string query = $"SELECT ProductID, Name, Price, Description, ImageDescription, Ratings FROM Menu WHERE Name LIKE '{searchString}%'";

            if (cuisineCBox.Text != null)
            {
                string cuisineFiltered = cuisineCBox.Text;
                query += $"AND Cuisine = '{cuisineFiltered}'";
            }
            if (priceRangeCBox.Text != null)
            {
                switch (priceRangeCBox.Text)
                {
                    case "RM1.00 - 10.00":
                        query += $"AND Price BETWEEN 1.00 AND 10.00";
                        break;
                    case "RM10.00 - 20.00":
                        query += $"AND Price BETWEEN 10.00 AND 20.00";
                        break;
                    case "RM20.00 - 30.00":
                        query += $"AND Price BETWEEN 20.00 AND 10.00";
                        break;
                    case "RM30.00 - 40.00":
                        query += $"AND Price BETWEEN 30.00 AND 40.00";
                        break;
                    case "RM40.00 - 50.00":
                        query += $"AND Price BETWEEN 40.00 AND 50.00";
                        break;
                    case "RM50.00 - 60.00":
                        query += $"AND Price BETWEEN 50.00 AND 60.00";
                        break;
                    case "RM60.00 - 70.00":
                        query += $"AND Price BETWEEN 60.00 AND 70.00";
                        break;
                    case "RM70.00 - 80.00":
                        query += $"AND Price BETWEEN 70.00 AND 80.00";
                        break;
                    case "RM80.00 - 90.00":
                        query += $"AND Price BETWEEN 80.00 AND 90.00";
                        break;
                    case "RM90.00 - 100.00":
                        query += $"AND Price BETWEEN 90.00 AND 100.00";
                        break;


                }
            }
            if (ratingsCBox.Text != null)
            {
                switch (ratingsCBox.Text)
                {
                    case "0.00 - 1.00":
                        query += $"AND Ratings BETWEEN 0.00 AND 1.00";
                        break;
                    case "1.00 - 2.00":
                        query += $"AND Ratings BETWEEN 1.00 AND 2.00";
                        break;
                    case "2.00 - 3.00":
                        query += $"AND Ratings BETWEEN 2.00 AND 3.00";
                        break;
                    case "3.00 - 4.00":
                        query += $"AND Ratings BETWEEN 3.00 AND 4.00";
                        break;
                    case "4.00 - 5.00":
                        query += $"AND Ratings BETWEEN 4.00 AND 5.00";
                        break;

                }
            }


                DataTable searchDataTable = database.getDataTable(query);

            foreach (DataRow row in searchDataTable.Rows)
            {
                string productID = row["ProductID"].ToString();
                string productName = row["Name"].ToString();
                string productPrice = row["Price"].ToString();
                string productDescription = row["Description"].ToString();
                string productImageDescription = row["ImageDescription"].ToString();
                string productRatingText = row["Ratings"].ToString();

                Image productImage = null;

                if (!string.IsNullOrEmpty(productImageDescription))
                {
                    productImage = Properties.Resources.DeliciousIcon;
                }

                var productButton = new foodButton(productID, productName, productPrice, productDescription, productImage, productRatingText);

                productDisplayFlowPanel.Controls.Add(productButton);
                
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
