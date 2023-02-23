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

namespace Patientenverwaltung.Gui
{
    public partial class NeuerPatientForm : Form
    {
        private Controller controller;

        public NeuerPatientForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btn_PatientHinzufuegen_Click(object sender, EventArgs e)
        {
            // TODO: Fehlende Felder in Gui hinzufügen, Vorkerkrankung erfassen, Dropdown mit Daten befüllen und erfassen 
            controller.navNeuerPatientToPatientOverview(
                new Patient()
                {
                    vorname = txt_Vorname.Text,
                    nachname= txt_Nachname.Text,
                    email = txt_Email.Text,
                    geburtstag = Convert.ToDateTime(txt_Geburtsdatum.Text),
                    adresse = new Adresse()
                    {
                        straße = txt_Straße.Text,
                        hausnummer = txt_HausNr.Text,
                        plz = Convert.ToInt32(txt_Plz.Text),
                        ort = txt_Ort.Text
                    },
                    versicherung = new Versicherung()
                    {
                        idVersicherung = 1
                    },
                    versicherungsnummer= 1,
                    telefonnummer = "TELEFONNUMMER",
                    vorerkrankungen = new List<Krankheitsbild>()
                }
                );
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navNeuerPatientToPatientOverview();
        }
    }
}
