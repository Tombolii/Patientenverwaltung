using Patientenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Patientenverwaltung.Gui
{
    
    public partial class ArztOverviewForm : Form
    {
        private Controller controller;
        private static int rowCount = 0;
        private int pageIndex = 0;
        private const int ROW_AMOUNT = 10;

        public ArztOverviewForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                Arzt loggedInArzt = controller.getLoggedInArzt();
                lbl_Name.Text = "Hallo " + loggedInArzt.vorname + " " + loggedInArzt.nachname;
                refreshTerminTable();
            }
        }

        public void displayTermineOfList(List<Termin> termineToShow)
        {
            tblTermine.Visible = false;
            clearTermineOverview();
            rowCount = 0;               
            for (int i = 0; i < termineToShow.Count; i++)
            {
                addTerminToFrontend(termineToShow[i]);
            }
            tblTermine.Visible = true;
        }

        public void addTerminToFrontend(Termin termin)
        {
            Label datumLabel = new Label();
            datumLabel.DoubleClick += onTerminDoubleClick;
            datumLabel.Text = termin.zeitpunkt.ToShortDateString();

            Label uhrzeitLabel = new Label();
            uhrzeitLabel.DoubleClick += onTerminDoubleClick;
            uhrzeitLabel.Text = termin.zeitpunkt.ToShortTimeString() + " Uhr";

            Label nachnameLabel = new Label();
            nachnameLabel.DoubleClick += onTerminDoubleClick;
            nachnameLabel.Text = termin.simplePatient.nachname;

            Label vornameLabel = new Label();
            vornameLabel.DoubleClick += onTerminDoubleClick;
            vornameLabel.Text = termin.simplePatient.vorname;

            tblTermine.Controls.Add(nachnameLabel, 2, rowCount);
            tblTermine.Controls.Add(vornameLabel, 3, rowCount);
            tblTermine.Controls.Add(datumLabel, 0, rowCount);
            tblTermine.Controls.Add(uhrzeitLabel, 1, rowCount);
            rowCount++;
        }

        private void btn_PatientenAnsehen_Click(object sender, EventArgs e)
        {
            controller.navArztOverviewToPatientOverview();
        }

        private void clearTermineOverview()
        {
            tblTermine.Controls.Clear();
        }

        private void refreshTerminTable()
        {
            int firstTerminIndexOfPage = pageIndex * ROW_AMOUNT;
            int lastTerminIndexOfPage = ROW_AMOUNT;
            if (firstTerminIndexOfPage + ROW_AMOUNT >= controller.getTermine().Count)
            {
                lastTerminIndexOfPage = controller.getTermine().Count - firstTerminIndexOfPage;
            }
            List<Termin> termineToShow = controller.getTermine().GetRange(firstTerminIndexOfPage, lastTerminIndexOfPage);
            if (!checkAlleTermine.Checked)
            {
                // Termine des aktuellen Tages anzeigen
                DateTime currentDate = DateTime.Now;
                termineToShow = termineToShow.FindAll(termin =>
                    termin.zeitpunkt.Date.Equals(currentDate.Date)
                );
            }
            displayTermineOfList(termineToShow);
            
            setVisibilityOfPageButtons();
        }

        private void btn_Weiter_Click(object sender, EventArgs e)
        {
            if (validateNextPage())
            {
                pageIndex++;
                lblPage.Text = (pageIndex + 1).ToString();
                setVisibilityOfPageButtons();
                refreshTerminTable();
            }
        }

        private void btn_Zurueck_Click(object sender, EventArgs e)
        {
            if (pageIndex != 0)
            {
                pageIndex--;
                lblPage.Text = (pageIndex + 1).ToString();
                setVisibilityOfPageButtons();
                refreshTerminTable();
            }
        }

        /// <summary>
        /// Setzt die Sichtbarkeit der Buttons für die Seiten
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
        /// Überprüft ob es noch eine weitere Seite gibt
        /// </summary>
        /// <returns></returns>
        private bool validateNextPage()
        {
            return (pageIndex + 1) * ROW_AMOUNT < controller.getPatienten().Count;
        }

        private void checkAlleTermine_CheckedChanged(object sender, EventArgs e)
        {
           refreshTerminTable();
        }

        public void onTerminDoubleClick(object sender, EventArgs e)
        {
            controller.setCurrentSelectedTermin(controller.getTermine()[tblTermine.GetRow((Control)sender)]);
            controller.navArztOverviewToTerminDaten();
        }
        public void ArztOverviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false;
                Application.Exit();
            }
        }
    }
}
