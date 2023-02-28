using System;
using System.Windows.Forms;
using Patientenverwaltung.Model;
using MySql.Data.MySqlClient;

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
                Patient currentPatient = controller.getCurrentSelectedPatient();
                lblPatientName.Text = currentPatient.nachname + ", " + currentPatient.vorname;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                controller.deletePatient();
            }
            catch (MySqlException ex)
            {
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
