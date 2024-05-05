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
    public partial class foodButton : UserControl
    {
        public foodButton(string productID,string productName, string productPrice, string productDescription, Image productImagePath)
        {
            InitializeComponent();
            this.lblProductID.Text = productID;
            this.lblProductName.Text = productName;
            this.lblProductPrice.Text = productPrice;
            this.lblProductDescription.Text = productDescription;
            this.productImagePBox.Image = productImagePath;
        }
        private void foodButton_Load(object sender, EventArgs e)
        {

        }

        private void productImagePBox_Click(object sender, EventArgs e)
        {

        }
    }
}
