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
    public partial class frmViewProfile : Form
    {
        public frmViewProfile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPro_Click(object sender, EventArgs e)
        {
            frmUpdateProfile form = new frmUpdateProfile();
            form.Show();
        }
    }
}
