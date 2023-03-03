using System;
using System.Windows.Forms;
using Patientenverwaltung.Model;

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

        /// <summary>
        /// Zeigt alle Daten des Patienten in der Form an
        /// </summary>
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
            displayVorerkrankungen(currentPatient);
        }

        private void btn_PatientLoeschen_Click(object sender, EventArgs e)
        {
            controller.navPatientenDatenToDeleteConfirmationPopup();
        }

        /// <summary>
        /// Zeigt alle Vorerkrankungen des Patienten in der Form an
        /// </summary>
        /// <param name="patient">der Patient</param>
        private void displayVorerkrankungen(Patient patient)
        {
            boxVorerkrankungen.Items.Clear();
            patient.vorerkrankungen.ForEach(k =>
                boxVorerkrankungen.Items.Add(k.idKrankheitsbild + ": " + k.bezeichnung));
        }

        public void PatientDatenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
