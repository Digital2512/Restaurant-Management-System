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
    public partial class CustomerSuccessfulPayment : Form
    {
        public CustomerSuccessfulPayment()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void homePageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerOrderPage customerOrderPage = new CustomerOrderPage();
            customerOrderPage.Show();
        }
    }
}
