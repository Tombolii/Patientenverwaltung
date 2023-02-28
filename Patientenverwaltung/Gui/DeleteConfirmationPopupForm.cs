using System;
using System.Windows.Forms;
using Patientenverwaltung.Model;

namespace Patientenverwaltung.Gui
{
    public partial class DeleteConfirmationPopupForm : Form
    {
        private Controller controller;

        public DeleteConfirmationPopupForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                Patient currentPatient = controller.getCurrentSelectedPatient();
                lblPatientName.Text = currentPatient.nachname + ", " + currentPatient.vorname;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            controller.deletePatient();
            controller.navDeleteConfirmationPopupToPatientOverview();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            controller.navDeleteConfirmationPopupToPatientenDaten();
        }
    }
}
