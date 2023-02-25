using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patientenverwaltung.Model;
using System.Windows.Forms;

namespace Patientenverwaltung.Gui
{
    public partial class PatientBearbeitenForm : Form
    {
        private Controller controller;

        public PatientBearbeitenForm(Controller controller)
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

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navPatientBearbeitenToPatientenDaten();
        }

        private void btn_AenderungUebernehmen_Click(object sender, EventArgs e)
        {
            Patient updatedPatient = controller.getCurrentSelectedPatient();
            updatedPatient.vorname = txt_Vorname.Text;
            updatedPatient.nachname = txt_Nachname.Text;
            updatedPatient.geburtstag = Convert.ToDateTime(txt_Geburtsdatum.Text);
            updatedPatient.email = txt_Email.Text;
            updatedPatient.adresse.straße = txt_Straße.Text;
            updatedPatient.adresse.plz = Convert.ToInt32(txt_Plz.Text);
            updatedPatient.adresse.ort = txt_Ort.Text;
            updatedPatient.adresse.hausnummer = txt_HausNr.Text;
            updatedPatient.telefonnummer = txt_Telefonnummer.Text;
            updatedPatient.versicherung = new Versicherung()
            {
                idVersicherung = 1
            };
            updatedPatient.vorerkrankungen = new List<Krankheitsbild>();
            controller.navPatientBearbeitenToPatientenDaten(updatedPatient);
        }

        private void displayPatientDaten()
        {
            Patient currentPatient = controller.getCurrentSelectedPatient();
            txt_Vorname.Text = currentPatient.vorname;
            txt_Nachname.Text = currentPatient.nachname;
            txt_Geburtsdatum.Text = currentPatient.geburtstag.Date.ToShortDateString();
            txt_Telefonnummer.Text = currentPatient.telefonnummer;
            txt_Email.Text = currentPatient.email;
            txt_Straße.Text = currentPatient.adresse.straße;
            txt_HausNr.Text = currentPatient.adresse.hausnummer;
            txt_Ort.Text = currentPatient.adresse.ort;
            txt_Plz.Text = currentPatient.adresse.plz.ToString();
        }
    }
}
