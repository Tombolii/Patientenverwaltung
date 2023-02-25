using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patientenverwaltung;
using System.Windows.Forms;
using Patientenverwaltung.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Patientenverwaltung.Gui
{
    public partial class PatientenDatenForm : Form
    {
        private Controller controller;

        public PatientenDatenForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                displayPatientDaten();
            }
        }

        private void btn_PatientBearbeiten_Click(object sender, EventArgs e)
        {
            controller.navPatientenDatenToPatientBearbeiten();
        }

        private void btn_Berichte_Click(object sender, EventArgs e)
        {
            controller.navPatientenDatenToBerichtOverview();
        }

        private void btn_Zurueck_Click(object sender, EventArgs e)
        {
            controller.navPatientenDatenToPatientOverview();
        }

        private void btn_TerminHinzufuegen_Click(object sender, EventArgs e)
        {
            controller.navPatientOverviewToNeuerTermin();
        }

        private void displayPatientDaten()
        {
            Patient currentPatient = controller.getCurrentSelectedPatient();
            txt_Vorname.Text = currentPatient.vorname;
            txt_Nachname.Text = currentPatient.nachname;
            txt_Geburtstag.Text = currentPatient.geburtstag.Date.ToShortDateString();
            txt_Telefonnummer.Text = currentPatient.telefonnummer;
            txt_Email.Text = currentPatient.email;
            txt_Adresse.Text = currentPatient.adresse.straße + " " + currentPatient.adresse.hausnummer;
            txt_Ort.Text = currentPatient.adresse.ort;
            txt_Kasse.Text = currentPatient.versicherung.name;
        }

        private void btn_PatientLoeschen_Click(object sender, EventArgs e)
        {
            controller.navPatientenDatenToDeleteConfirmationPopup();
        }
    }
}
