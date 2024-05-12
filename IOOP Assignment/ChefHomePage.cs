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
    public partial class ChefHomePage : Form
    {
        bool sidebarExpand;
        public ChefHomePage()
        {
            InitializeComponent();
        }


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonViewOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Now navigating to Order Details Function Page");
            ChefOrderDetailsForm OD = new ChefOrderDetailsForm();
            OD.ShowDialog();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Now navigating to Order Details Function Page");
            ChefInventoryForm IS = new ChefInventoryForm ();
            IS.ShowDialog();
        }
    }
}
