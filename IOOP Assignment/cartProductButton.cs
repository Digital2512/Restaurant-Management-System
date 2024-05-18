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
    public partial class cartProductButton: UserControl
    {
        public string orderDetailsID;
        public cartProductButton(string produtName, string productSpecialInstructions, string productPrice, string productQuantity, Image productImage, string orderDetailsID)
        {
            InitializeComponent();
            lblProductName.Text = produtName;
            lblProductSpecialInstructions.Text = productSpecialInstructions;
            lblProductPrice.Text = productPrice;
            lblProductQuantity.Text = productQuantity;
            productImagePBox.Image = productImage;
            this.orderDetailsID = orderDetailsID;
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
            string ConnectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
            Database database = new Database(ConnectionString);
            string query = "SELECT OrderDetailsIDs FROM Orders WHERE OrderStatus = 'ORDERING';";
            string orderDetailsIDs = database.getString(query);
            MessageBox.Show(orderDetailsIDs);
            
            List<String> orderDetailsIDsList = new List<String>(orderDetailsIDs.Split(','));
            if (orderDetailsIDsList.Contains(orderDetailsID))
            {
                orderDetailsIDsList.Remove(orderDetailsID);
            }
            string newOrderDetailsIDsString = string.Join(",", orderDetailsIDsList);

            query = $"UPDATE Orders SET OrderDetailsIDs = '{newOrderDetailsIDsString}' WHERE OrderStatus = 'ORDERING'";
            if(database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
