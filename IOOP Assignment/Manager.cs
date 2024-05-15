using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    class Manager
    {
        public static void OpenManagerHomePage()
        {
            // Hide the current form
            Form frmcurrent = Form.ActiveForm;
            if (frmcurrent != null)
            {
                frmcurrent.Hide();
            }
            // Open ManagerHomePage
            ManagerHomePage frmMngHome = new ManagerHomePage();
            frmMngHome.ShowDialog();
        }

    }
}
