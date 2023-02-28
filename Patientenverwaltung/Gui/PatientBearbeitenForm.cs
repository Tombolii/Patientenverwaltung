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
using MySql.Data.MySqlClient;

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

            List<Versicherung> versicherungen = controller.getVersicherungen();
            List<Krankheitsbild> krankheitsbilder = controller.getKrankheitsbilder();

            foreach (var Versicherung in versicherungen)
            {
                box_Krankenkasse.Items.Add(Versicherung.idVersicherung + ": " + Versicherung.name);
            }

            foreach (var Krankheitsbild in krankheitsbilder)
            {
                box_Vorerkrankungen.Items.Add(Krankheitsbild.idKrankheitsbild + ": " + Krankheitsbild.bezeichnung);
            }

        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navPatientBearbeitenToPatientenDaten();
        }

        private void btn_AenderungUebernehmen_Click(object sender, EventArgs e)
        {
            string krankenversicherung = box_Krankenkasse.GetItemText(box_Krankenkasse.SelectedItem);
            string[] subs = krankenversicherung.Split(':');
            int idKrankenversicherung = Convert.ToInt32(subs[0]);
            string nameKrankenversicherung = subs[1];

            string vorerkrankungenPat = box_Krankenkasse.GetItemText(box_Krankenkasse.SelectedItem);
            string[] subs2 = vorerkrankungenPat.Split(':');
            int idVorerkrankungPat = Convert.ToInt32(subs2[0]);
            string bezeichnungVorerkrankungPat = subs2[1];

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
                idVersicherung = idKrankenversicherung,
                name = nameKrankenversicherung,
            };
            updatedPatient.vorerkrankungen = new List<Krankheitsbild>();
            try
            {
                controller.navPatientBearbeitenToPatientenDaten(updatedPatient);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
            box_Krankenkasse.Text = currentPatient.versicherung.idVersicherung + ": " + currentPatient.versicherung.name;
            //box_Vorerkrankungen.Text = currentPatient.vorerkrankungen

            /*List<Krankheitsbild> krankheitsbilder = controller.getKrankheitsbilder();

            foreach (var krankheitsbild in krankheitsbilder)
            {
                box_Krankenkasse.Items.Add(krankheitsbild);
            }*/
        }

        private void box_Krankenkasse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
