using System;
using System.Collections.Generic;
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
                displayVorerkrankungen();
            }
        }

        private void btn_PatientHinzufuegen_Click(object sender, EventArgs e)
        {
            if(validateInputs())
            {
                try
                {
                    controller.createPatient(getPatientFromForm());
                    controller.navNeuerPatientToPatientOverview();
                    MessageBox.Show("Der Patient wurde hinzugefügt!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Es konnte kein Patient hinzugefügt werden! Bitte Eingabe überprüfen.");
                }
            }
            else
            {
                MessageBox.Show("Bitte alle Felder füllen!");
            }
        }

        /// <summary>
        /// Holten den Patienten von der Form
        /// </summary>
        /// <returns>den neuen Patienten</returns>
        private Patient getPatientFromForm()
        {
            string[] versicherungSplit = box_Krankenkasse.GetItemText(box_Krankenkasse.SelectedItem).Split(':');
            return new Patient()
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
                    idVersicherung = Convert.ToInt32(versicherungSplit[0]),
                    name = versicherungSplit[1].Trim()
                },
                versicherungsnummer = 1,
                telefonnummer = txt_Telefonnummer.Text,
                vorerkrankungen = getVorerkrankungenOfForm()
            };
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navNeuerPatientToPatientOverview();
        }

        /// <summary>
        /// Zeigt Krankheitsbilder, die noch hinzugefügt werden können
        /// </summary>
        private void displayVorerkrankungen()
        {
            // Anzeigen der Vorerkrankungen, die noch hinzugefügt werden können
            boxSelectableVorerkrankungen.Items.Clear();
            controller.getKrankheitsbilder().ForEach(selectableKrankheitsbild =>
            {
                boxSelectableVorerkrankungen.Items.Add(selectableKrankheitsbild.idKrankheitsbild + ": " + selectableKrankheitsbild.bezeichnung);
            });
        }

        /// <summary>
        /// Extrahiert die Vorerkrankungen aus der Form
        /// </summary>
        /// <returns>Liste aller Vorerkrankungen</returns>
        private List<Krankheitsbild> getVorerkrankungenOfForm()
        {
            List<Krankheitsbild> vorerkrankungen = new List<Krankheitsbild>();
            foreach (string item in boxSelectedVorerkrankungen.Items)
            {
                string[] split = item.Split(':');
                vorerkrankungen.Add(
                    new Krankheitsbild()
                    {
                        idKrankheitsbild = Convert.ToInt32(split[0]),
                        bezeichnung = split[1].Trim()
                    }
                    );
            }
            return vorerkrankungen;
        }

        private void btnAddSelectedVorerkrankungen_Click(object sender, EventArgs e)
        {
            // Hinzufügen zur Vorerkrankungen-Box
            foreach (string item in boxSelectableVorerkrankungen.SelectedItems)
            {
                boxSelectedVorerkrankungen.Items.Add(item);
            }
            clearSelectedItemsOfListBox(boxSelectableVorerkrankungen);
        }

        private void btnRemoveSelectedVorerkrankungen_Click(object sender, EventArgs e)
        {
            foreach (string item in boxSelectedVorerkrankungen.SelectedItems)
            {
                boxSelectableVorerkrankungen.Items.Add(item);
            }
            clearSelectedItemsOfListBox(boxSelectedVorerkrankungen);
        }

        /// <summary>
        /// Entfernt alle selektierten Items einer ListBox
        /// </summary>
        /// <param name="listBox">ListBox</param>
        private void clearSelectedItemsOfListBox(ListBox listBox)
        {
            for (int i = listBox.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = listBox.SelectedIndices[i];
                listBox.Items.RemoveAt(index);
            }
        }

        private bool validateInputs()
        {
            return txt_Vorname.Text != "" ||
                txt_Nachname.Text != "" ||
                txt_Email.Text != "" ||
                txt_Geburtsdatum.Text != "" ||
                txt_Ort.Text != "" ||
                txt_Straße.Text != "" ||
                txt_Ort.Text != "" ||
                txt_Plz.Text != "" ||
                txt_HausNr.Text != "" ||
                txt_Telefonnummer.Text != "";
        }

        public void NeuerPatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

    }
}
