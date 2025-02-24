﻿using System;
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
        public string UserID;
        public CustomerSuccessfulPayment(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
        }

        private void homePageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHomePage customerHomePage = new CustomerHomePage(UserID);
            customerHomePage.Show();
        }
    }
}
