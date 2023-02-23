﻿using System;
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
using System.Diagnostics.SymbolStore;

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
                selectedPatientIndex = -1;
                refreshPatientTable();
            }
        }

        private void displayPatientenOfList(List<Patient> patientenToShow)
        {
            //tblPatientInformationen.Visible = false;
            rowCount = 0;
            clearPatientenOverview();
            for (int i = 0; i < patientenToShow.Count; i++)
            {
                addPatientToFrontend(patientenToShow[i]);
            }
            //tblPatientInformationen.Visible = true;
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

            Label adresseLabel = new Label();
            adresseLabel.Click += onPatientSelected;
            adresseLabel.Text = Convert.ToString(patient.adresse);

            Label versicherungLabel = new Label();
            versicherungLabel.Click += onPatientSelected;
            versicherungLabel.Text = Convert.ToString(patient.versicherung);

            tblPatientInformationen.Controls.Add(idLabel, 0, rowCount); ;
            tblPatientInformationen.Controls.Add(nachnameLabel, 1, rowCount);
            tblPatientInformationen.Controls.Add(vornameLabel, 2, rowCount);
            tblPatientInformationen.Controls.Add(geburtstagLabel, 3, rowCount);
            tblPatientInformationen.Controls.Add(adresseLabel, 4, rowCount);
            tblPatientInformationen.Controls.Add(versicherungLabel, 5, rowCount);
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
            displayPatientenOfList(matchingPatienten);
        }

        private void clearPatientenOverview()
        {
            tblPatientInformationen.Controls.Clear();
            rowCount = 0;
        }

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
            Label label = (Label) sender;
            
            // Auslesen des Indexes bzw. Zeile des ausgewählten Patienten
            selectedPatientIndex = tblPatientInformationen.GetRow((Control)sender);

            // Button zum Erstellen von Terminen aktivieren
            btn_TerminHinzufuegen.Enabled = true;

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

        private void btn_TerminHinzufuegen_Click(object sender, EventArgs e)
        {
            // Ausgewählten Patient im Controller setzen
            controller.setcurrentSelectedPatient(controller.getPatienten()[selectedPatientIndex]);

            controller.navPatientOverviewToNeuerTermin();
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

        private bool validateNextPage()
        {
            return (pageIndex + 1) * ROW_AMOUNT < controller.getPatienten().Count;
        }
    }
}
