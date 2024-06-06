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
        public string ProductID;
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public string UserID;

        public cartProductButton(string userID,string productID, string productName, string productSpecialInstructions, decimal productPrice, string productQuantity, Image productImage, string orderDetailsID)
        {
            InitializeComponent();
            this.UserID = userID;
            lblProductID.Text = productID;
            lblProductName.Text = productName;
            lblProductSpecialInstructions.Text = productSpecialInstructions;
            lblProductQuantity.Text = productQuantity;
            int productQuantityint = int.Parse(productQuantity);
            decimal totalIndividualProductPrice = productPrice * productQuantityint; 
            lblProductPrice.Text = $"RM {totalIndividualProductPrice.ToString()}";
            productImagePBox.Image = productImage;
            this.orderDetailsID = orderDetailsID;
            this.ProductID = productID;
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
                    CustomerCartPage CustomerCartPage = new CustomerCartPage(UserID);
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
            string query = $"SELECT OrderSpecialInstructions FROM OrderDetails WHERE OrderDetailsID = '{orderDetailsID}'";
            string orderSpecialInstructions = database.getString(query);
            query = $"SELECT Quantity FROM OrderDetails WHERE OrderDetailsID = '{orderDetailsID}'";
            int orderQuantity = database.getInt(query);
            
            MessageBox.Show(orderDetailsID);
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
                MessageBox.Show(ProductID);
                query = $"UPDATE Menu SET Chosen = 'TRUE' WHERE ProductID = '{ProductID}'";
                if(database.insertOrUpdateValuesIntoDatabase(query) == true)
                {
                    query = $"DELETE FROM OrderDetails WHERE OrderDetailsID = '{orderDetailsID}';";
                    database.insertOrUpdateValuesIntoDatabase(query);
                    FlowLayoutPanel flowLayoutPanel = this.Parent as FlowLayoutPanel;
                    Form mainForm = flowLayoutPanel?.FindForm();

                    if (mainForm != null)
                    {
                        mainForm.Hide();
                        CustomerIndividualProductPage customerIndividualProductPage = new CustomerIndividualProductPage(UserID, orderSpecialInstructions, orderQuantity);
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