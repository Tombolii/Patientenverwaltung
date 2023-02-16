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
    public partial class Patienten : Form
    {
        private Controller controller;
        private static int rowCount = 0;
        public Patienten(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        /*
        public void displayAllPatienten()
        {
            List<Patient> patient = controller.GetPatienten();
            for (int i = 0; i < patient.Count; i++)
            { addPatientToFrontend(patient[i]);
            }
        }

        public void addPatientToFrontend(Patient patient)
        {
            tblPatientInformationen.Controls.Add(new Label() { Text = patient.nachname }, 1, rowCount);
            tblPatientInformationen.Controls.Add(new Label() { Text = patient.vorname }, 2, rowCount);
            tblPatientInformationen.Controls.Add(new Label() { Text = Convert.ToString(patient.geburtstag) }, 3, rowCount);
            tblPatientInformationen.Controls.Add(new Label() { Text = Convert.ToString(patient.adresse) }, 4, rowCount);
            tblPatientInformationen.Controls.Add(new Label() { Text = Convert.ToString(patient.versicherung) }, 5, rowCount);
            rowCount++;
        }
        */

        private void btn_Startseite_Click(object sender, EventArgs e)
        {
            controller.patientenBackToStart();
        }

        private void btn_PatientHinzufuegen_Click(object sender, EventArgs e)
        {
            controller.patientAddPat();
        }

        private void btn_PatientSuchen_Click(object sender, EventArgs e)
        {
            //controller.patientSearchPat();
        }

        private void Patienten_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Patienten_Load(object sender, EventArgs e)
        {

        }
    }
}
