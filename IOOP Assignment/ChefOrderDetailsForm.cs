using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ChefOrderDetailsForm : Form
    {
        private System.Timers.Timer timer;

        public ChefOrderDetailsForm()
        {
            InitializeComponent();
            lblrealtime.Text = DateTime.Now.ToString("MMMM d, yyyy\nh:mm:ss tt");
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += UpdateTimeLabel;
            timer.Start();
        }
        private void UpdateTimeLabel(object sender, ElapsedEventArgs e)
        {
            if (lblrealtime.InvokeRequired)
            {
                lblrealtime.Invoke(new Action(() => lblrealtime.Text = DateTime.Now.ToString("MMMM d, yyyy\nh:mm:ss tt")));
            }
            else
            {
                lblrealtime.Text = DateTime.Now.ToString("MMMM d, yyyy\nh:mm:ss tt");  // Update directly if on UI thread
            }
        }

        private void BbackH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChefOrderDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}


