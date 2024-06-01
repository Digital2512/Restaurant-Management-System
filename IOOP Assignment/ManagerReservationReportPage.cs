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
    public partial class ManagerReservationReportPage : Form
    {
        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";
        DataTable reservationData;
        public ManagerReservationReportPage()
        {
            InitializeComponent();
            InitializeReservationData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();
        }

        private void InitializeReservationData()
        {
            // Get initial filter values
            string selectedMonth = cbbMonth.SelectedItem?.ToString();
            string selectedReservationType = cbbResvType.SelectedItem?.ToString();
            

            // Get reservation data based on initial filters
            
        }
    }
}
