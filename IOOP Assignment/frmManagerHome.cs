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
    public partial class frmManagerHome : Form
    {
        public frmManagerHome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmViewProfile form = new frmViewProfile();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            form.Show();
        }
    }
}
