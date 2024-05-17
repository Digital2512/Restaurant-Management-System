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
    public partial class ManagerTableInformationPage : Form
    {
        private string placeID;
        public ManagerTableInformationPage(string placeID)
        {
            InitializeComponent();
            this.placeID = placeID;
        }

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";


    }
}
