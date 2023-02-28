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
using MySql.Data.MySqlClient;

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

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
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
        }

        private void btn_PatientHinzufuegen_Click(object sender, EventArgs e)
        {
            // TODO: Fehlende Felder in Gui hinzufügen, Vorkerkrankung erfassen, Dropdown mit Daten befüllen und erfassen 
            string krankenversicherung = box_Krankenkasse.GetItemText(box_Krankenkasse.SelectedItem);
            string[] subs = krankenversicherung.Split(':');
            string idKrankenversicherung = subs[0];
            string nameKrankenversicherung = subs[1];

            try
            {
                controller.navNeuerPatientToPatientOverview(
                    new Patient()
                    {
                        vorname = txt_Vorname.Text,
                        nachname = txt_Nachname.Text,
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
                            idVersicherung = 1,
                        },
                        versicherungsnummer = 1,
                        telefonnummer = txt_Telefonnummer.Text,
                        vorerkrankungen = new List<Krankheitsbild>()
                    }
                    );
            } catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navNeuerPatientToPatientOverview();
        }

        private void box_Krankenkasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
