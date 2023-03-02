using System;
using System.Windows.Forms;
using Patientenverwaltung.Model;

namespace Patientenverwaltung.Gui
{
    public partial class DeletePatientConfirmationPopupForm : Form
    {
        private Controller controller;

        public DeletePatientConfirmationPopupForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                displayPatientName();
            }
        }

        private void displayPatientName()
        {
            Patient currentPatient = controller.getCurrentSelectedPatient();
            lblPatientName.Text = currentPatient.nachname + ", " + currentPatient.vorname;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                controller.deletePatient();
                MessageBox.Show("Der Patient wurde erfolgreich gelöscht!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Der Patient konnte nicht gelöscht werden! Bitte Eingabe überprüfen.");
                Console.WriteLine(ex.Message);
            }
            controller.navDeletePatientConfirmationPopupToPatientOverview();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            controller.navDeletePatientConfirmationPopupToPatientenDaten();
        }
    }
}
