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
        public cartProductButton(string produtName, string productSpecialInstructions, string productPrice, string productQuantity)
        {
            InitializeComponent();
            lblProductName.Text = produtName;
            lblProductSpecialInstructions.Text = productSpecialInstructions;
            lblProductPrice.Text = productPrice;
            lblProductQuantity.Text = productQuantity;
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

        }
    }
}
