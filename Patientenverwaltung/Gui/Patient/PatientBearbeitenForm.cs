using System;
using System.Collections.Generic;
using System.Linq;
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
            if (validateInputs()){
                try
                {
                    Patient updatedPatient = getPatientenDatenOfForm();
                    controller.updatePatient(updatedPatient);
                    controller.navPatientBearbeitenToPatientenDaten();
                    MessageBox.Show("Der Patient wurde bearbeitet!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Patient konnte nicht bearbeitet werden! Bitte Eingabe überprüfen.");
                }
            }
            else
            {
                MessageBox.Show("Bitte alle Felder füllen!");
            }
        }

        /// <summary>
        /// Zeigt alle Daten des Patienten in der Form an
        /// </summary>
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
            displayVersicherungDropdown();
            box_Krankenkasse.Text = currentPatient.versicherung.idVersicherung + ": " + currentPatient.versicherung.name;
            displayVorerkrankungen(currentPatient);
        }

        /// <summary>
        /// Zieht die Daten des Patienten aus dem Formular
        /// </summary>
        /// <returns>den Patienten</returns>
        private Patient getPatientenDatenOfForm()
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
            updatedPatient.versicherung = getKrankenversicherungOfForm();
            updatedPatient.vorerkrankungen = getVorerkrankungenOfForm();
            return updatedPatient;
        }

        /// <summary>
        /// Extrahiert die Krankenversicherung aus der Form
        /// </summary>
        /// <returns>die Krankenversicherung</returns>
        private Versicherung getKrankenversicherungOfForm()
        {
            // Ausgewählte Krankenversicherung abziehen
            string[] krankenversicherungSubs = box_Krankenkasse.GetItemText(box_Krankenkasse.SelectedItem).Split(':');

            return new Versicherung()
            {
                idVersicherung = Convert.ToInt32(krankenversicherungSubs[0]),
                name = krankenversicherungSubs[1].Trim()
            };
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
                        bezeichnung= split[1].Trim()
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
        /// Füllt das VersicherungsDropdown
        /// </summary>
        private void displayVersicherungDropdown()
        {
            foreach (var Versicherung in controller.getVersicherungen())
            {
                box_Krankenkasse.Items.Add(Versicherung.idVersicherung + ": " + Versicherung.name);
            }
        }

        /// <summary>
        /// Zeigt die aktuellen Krankheitsbilder des Patienten an und die, die noch hinzugefügt werden können
        /// </summary>
        /// <param name="currentPatient">betroffener Patient</param>
        private void displayVorerkrankungen(Patient currentPatient)
        {
            // Anzeigen der aktuellen Vorerkrankungen
            boxSelectedVorerkrankungen.Items.Clear();
            currentPatient.vorerkrankungen.ForEach(k =>
                boxSelectedVorerkrankungen.Items.Add(k.idKrankheitsbild + ": " + k.bezeichnung));

            // Anzeigen der Vorerkrankungen, die noch hinzugefügt werden können
            boxSelectableVorerkrankungen.Items.Clear();
            controller.getKrankheitsbilder().ForEach(selectableKrankheitsbild =>
            {
                if (!currentPatient.vorerkrankungen.Any(vorerkrankung => vorerkrankung.idKrankheitsbild == selectableKrankheitsbild.idKrankheitsbild))
                {
                    boxSelectableVorerkrankungen.Items.Add(selectableKrankheitsbild.idKrankheitsbild + ": " + selectableKrankheitsbild.bezeichnung);
                }
            });
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
    }
}
