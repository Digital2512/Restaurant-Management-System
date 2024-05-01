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
    public partial class CustomerHomePage : Form
    {
        public CustomerHomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 40)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    reservationPnl.Width = sidebar.Width;
                    orderPnl.Width = sidebar.Width;
                    feedbackPnl.Width = sidebar.Width;
                    logoutPnl.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 120)
                {
                    sidebarExpand= true;
                    sidebarTransition.Stop();

                    reservationPnl.Width = sidebar.Width;
                    orderPnl.Width = sidebar.Width;
                    feedbackPnl.Width = sidebar.Width;
                    logoutPnl.Width = sidebar.Width;
                }
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
