using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientenverwaltung.Gui
{
    public partial class AdminForm : Form
    {

        private Controller controller;

        public AdminForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            controller.navAdminToLogin();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            controller.navAdminToLogin();
        }
    }
}
