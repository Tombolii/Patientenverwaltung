using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Patientenverwaltung.Model;

namespace Patientenverwaltung.Gui
{
    public partial class PatientOverviewForm : Form
    {
        private Controller controller;
        private static int rowCount = 0;
        private int selectedPatientIndex;
        private int pageIndex = 0;
        private const int ROW_AMOUNT = 9;

        public PatientOverviewForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if(Visible)
            {
                btn_PatientAnzeigen.Enabled = false;
                selectedPatientIndex = -1;
                refreshPatientTable();
            }
        }

        private void displayPatientenOfList(List<Patient> patientenToShow)
        {
            rowCount = 0;
            clearPatientenOverview();
            for (int i = 0; i < patientenToShow.Count; i++)
            {
                addPatientToFrontend(patientenToShow[i]);
            }
        }

        private void addPatientToFrontend(Patient patient)
        {
            Label idLabel = new Label();
            idLabel.Click += onPatientSelected;
            idLabel.Text = patient.idPatient.ToString();

            Label vornameLabel = new Label();
            vornameLabel.Click += onPatientSelected;
            vornameLabel.Text = patient.vorname;

            Label nachnameLabel = new Label();
            nachnameLabel.Click += onPatientSelected;
            nachnameLabel.Text = patient.nachname;

            Label geburtstagLabel = new Label();
            geburtstagLabel.Click += onPatientSelected;
            geburtstagLabel.Text = Convert.ToString(patient.geburtstag);

            Label ortLabel = new Label();
            ortLabel.Click += onPatientSelected;
            ortLabel.Text = Convert.ToString(patient.adresse.ort);

            Label adresseLabel = new Label();
            adresseLabel.Click += onPatientSelected;
            adresseLabel.Text = Convert.ToString(patient.adresse.straße + " " + patient.adresse.hausnummer);

            Label versicherungLabel = new Label();
            versicherungLabel.Click += onPatientSelected;
            versicherungLabel.Text = Convert.ToString(patient.versicherung.name);

            tblPatientInformationen.Controls.Add(idLabel, 0, rowCount); ;
            tblPatientInformationen.Controls.Add(nachnameLabel, 1, rowCount);
            tblPatientInformationen.Controls.Add(vornameLabel, 2, rowCount);
            tblPatientInformationen.Controls.Add(geburtstagLabel, 3, rowCount);
            tblPatientInformationen.Controls.Add(ortLabel, 4, rowCount);
            tblPatientInformationen.Controls.Add(adresseLabel, 5, rowCount);
            tblPatientInformationen.Controls.Add(versicherungLabel, 6, rowCount);
            rowCount++;
        }

        private void btn_Startseite_Click(object sender, EventArgs e)
        {
            controller.navPatientOverviewToArztOverview();
        }

        private void btn_PatientHinzufuegen_Click(object sender, EventArgs e)
        {
            controller.navPatientOverviewToNeuerPatient();
        }

        private void btn_PatientSuchen_Click(object sender, EventArgs e)
        {
            string patientNachname = txtSucheNachname.Text;
            List<Patient> matchingPatienten = controller.getPatienten().FindAll
                (patient => patient.nachname.Contains(patientNachname));
            tblPatientInformationen.Visible = false;
            displayPatientenOfList(matchingPatienten);
            tblPatientInformationen.Visible = true;
        }

        private void clearPatientenOverview()
        {
            tblPatientInformationen.Controls.Clear();
            rowCount = 0;
        }

        /// <summary>
        /// Aktualisiert die Patienten-Daten der aktuellen Seite
        /// </summary>
        private void refreshPatientTable()
        {
            int firstPatientIndexOfPage = pageIndex * ROW_AMOUNT;
            int lastPatientIndexOfPage = ROW_AMOUNT;
            if (firstPatientIndexOfPage + ROW_AMOUNT >= controller.getPatienten().Count)
            {
                lastPatientIndexOfPage = controller.getPatienten().Count - firstPatientIndexOfPage;
            }
            displayPatientenOfList(controller.getPatienten().GetRange(firstPatientIndexOfPage, lastPatientIndexOfPage));
            setVisibilityOfPageButtons();
        }

        /// <summary>
        /// Wird aufgerufen, wenn ein Patient geklickt wird
        /// </summary>
        private void onPatientSelected(object sender, EventArgs e)
        {            
            // Auslesen des Indexes bzw. Zeile des ausgewählten Patienten
            selectedPatientIndex = tblPatientInformationen.GetRow((Control)sender);

            // Button zum Erstellen von Terminen aktivieren
            btn_PatientAnzeigen.Enabled = true;

            // Neues Generieren der Table (Triggert tblPatientInformationen_CellPaint())
            tblPatientInformationen.Invalidate();
        }

        /// <summary>
        /// Erzeugt die Tabelle der Form neu
        /// </summary>
        private void tblPatientInformationen_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == selectedPatientIndex)
            {
                foreach (Control control in tblPatientInformationen.Controls)
                {
                    if (tblPatientInformationen.GetRow(control) == e.Row && tblPatientInformationen.GetColumn(control) == 0)
                    {
                        // Erstes Feld der markierten Reihe Blau markieren
                        control.BackColor = Color.LightBlue;
                    } else
                    {
                        // Andere Felder normal anzeigen
                        control.BackColor = Color.Transparent;
                    }

                }
            }
        }

        private void btn_PatientAnzeigen_Click(object sender, EventArgs e)
        {
            // Ausgewählten Patient im Controller setzen
            controller.setCurrentSelectedPatient(controller.getPatienten()[selectedPatientIndex]);

            controller.navPatientOverviewToPatientenDaten();
        }

        private void btn_Weiter_Click(object sender, EventArgs e)
        {
            if (validateNextPage())
            {
                pageIndex++;
                lblPage.Text = (pageIndex + 1).ToString();
                setVisibilityOfPageButtons();
                refreshPatientTable();
            }

        }

        private void btn_Zurueck_Click(object sender, EventArgs e)
        {
            if (pageIndex != 0)
            {
                pageIndex--;
                lblPage.Text = (pageIndex + 1).ToString();
                setVisibilityOfPageButtons();
                refreshPatientTable();
            }
        }

        /// <summary>
        /// Setzt die Sichtbarkeit der Buttons zur Navigation zwischen den Seiten
        /// </summary>
        private void setVisibilityOfPageButtons()
        {
            if (pageIndex == 0)
            {
                btn_Zurueck.Enabled = false;
            }
            else
            {
                btn_Zurueck.Enabled = true;
            }
            if (!validateNextPage())
            {
                btn_Weiter.Enabled = false;
            }
            else
            {
                btn_Weiter.Enabled = true;
            }
        }

        /// <summary>
        /// Überprüft, ob es noch eine weitere Seite gibt
        /// </summary>
        /// <returns>true, falls ja</returns>
        private bool validateNextPage()
        {
            return (pageIndex + 1) * ROW_AMOUNT < controller.getPatienten().Count;
        }

        public void PatientOverviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
