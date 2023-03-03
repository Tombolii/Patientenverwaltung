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
                MessageBox.Show("Termin erfolgreich gelöscht!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Termin konnte nicht gelöscht werden!");
            }
            controller.navDeleteTerminConfirmationPopupToArztOverview();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            controller.navDeleteTerminConfirmationPopupToTerminDaten();
        }

        public void DeleteTerminConformationPpupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
