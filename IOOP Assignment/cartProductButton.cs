using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class cartProductButton : UserControl
    {
        public string orderDetailsID;
        public string productID;
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public cartProductButton(string productID, string productName, string productSpecialInstructions, string productPrice, string productQuantity, Image productImage, string orderDetailsID)
        {
            InitializeComponent();
            lblProductID.Text = productID;
            lblProductName.Text = productName;
            lblProductSpecialInstructions.Text = productSpecialInstructions;
            lblProductPrice.Text = productPrice;
            lblProductQuantity.Text = productQuantity;
            productImagePBox.Image = productImage;
            this.orderDetailsID = orderDetailsID;
            this.productID = productID;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblSpecialInstructions_Click(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            string query = $"DELETE FROM OrderDetails WHERE OrderDetailsID = '{orderDetailsID}';";
            MessageBox.Show(orderDetailsID);
            database.insertOrUpdateValuesIntoDatabase(query);

            query = "SELECT OrderDetailsIDs FROM Orders WHERE OrderStatus = 'ORDERING';";
            string orderDetailsIDs = database.getString(query);

            List<string> orderDetailsIDsList = new List<string>(orderDetailsIDs.Split(','));
            if (orderDetailsIDsList.Contains(orderDetailsID))
            {
                orderDetailsIDsList.Remove(orderDetailsID);
            }
            string newOrderDetailsIDsString = string.Join(",", orderDetailsIDsList);

            query = $"UPDATE Orders SET OrderDetailsIDs = '{newOrderDetailsIDsString}' WHERE OrderStatus = 'ORDERING';";
            if (database.insertOrUpdateValuesIntoDatabase(query))
            {
                FlowLayoutPanel flowLayoutPanel = this.Parent as FlowLayoutPanel;
                Form mainForm = flowLayoutPanel?.FindForm();

                if(mainForm != null)
                {
                    mainForm.Hide();
                    CustomerCartPage CustomerCartPage = new CustomerCartPage();
                    CustomerCartPage.Show();
                }
                else
                {
                    MessageBox.Show("Parent Form Not Found");
                }
            }
            else
            {
                MessageBox.Show("Failed to update the order details.");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            MessageBox.Show(orderDetailsID);
            string query = "SELECT OrderDetailsIDs FROM Orders WHERE OrderStatus = 'ORDERING';";
            string orderDetailsIDs = database.getString(query);

            List<string> orderDetailsIDsList = new List<string>(orderDetailsIDs.Split(','));
            if (orderDetailsIDsList.Contains(orderDetailsID))
            {
                orderDetailsIDsList.Remove(orderDetailsID);
            }
            string newOrderDetailsIDsString = string.Join(",", orderDetailsIDsList);

            query = $"UPDATE Orders SET OrderDetailsIDs = '{newOrderDetailsIDsString}' WHERE OrderStatus = 'ORDERING';";
            if (database.insertOrUpdateValuesIntoDatabase(query))
            {
                MessageBox.Show(productID);
                query = $"UPDATE Menu SET Chosen = 'TRUE' WHERE ProductID = '{productID}'";
                if(database.insertOrUpdateValuesIntoDatabase(query) == true)
                {
                    query = $"DELETE FROM OrderDetails WHERE OrderDetailsID = '{orderDetailsID}';";
                    database.insertOrUpdateValuesIntoDatabase(query);
                    FlowLayoutPanel flowLayoutPanel = this.Parent as FlowLayoutPanel;
                    Form mainForm = flowLayoutPanel?.FindForm();

                    if (mainForm != null)
                    {
                        mainForm.Hide();
                        CustomerIndividualProductPage customerIndividualProductPage = new CustomerIndividualProductPage();
                        customerIndividualProductPage.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to edit the product (Chosen Changed)");
                }
            }
            else
            {
                MessageBox.Show("Failed to edit the product (Order changed)");
            }
        }
    }
}