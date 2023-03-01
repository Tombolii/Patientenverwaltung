using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Patientenverwaltung.Gui
{
    public partial class DeleteTerminConfirmationPopupForm : Form
    {
        private Controller controller;
        public DeleteTerminConfirmationPopupForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                controller.deleteCurrentTermin();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            controller.navDeleteTerminConfirmationPopupToArztOverview();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            controller.navDeleteTerminConfirmationPopupToTerminDaten();
        }
    }
}
