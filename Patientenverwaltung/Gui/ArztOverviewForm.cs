using Patientenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                refreshPatientTable();
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
            tblTermine.Controls.Add(new Label() { Text = termin.simplePatient.nachname }, 2, rowCount);
            tblTermine.Controls.Add(new Label() { Text = termin.simplePatient.vorname }, 3, rowCount);
            tblTermine.Controls.Add(new Label() { Text = termin.zeitpunkt.ToString("dd,MM,yyyy") }, 0, rowCount);
            tblTermine.Controls.Add(new Label() { Text = termin.zeitpunkt.ToString("H:mm") + " Uhr" }, 1, rowCount);
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

        private void refreshPatientTable()
        {
            int firstTerminIndexOfPage = pageIndex * ROW_AMOUNT;
            int lastTerminIndexOfPage = ROW_AMOUNT;
            if (firstTerminIndexOfPage + ROW_AMOUNT >= controller.getTermine().Count)
            {
                lastTerminIndexOfPage = controller.getTermine().Count - firstTerminIndexOfPage;
            }
            displayTermineOfList(controller.getTermine().GetRange(firstTerminIndexOfPage, lastTerminIndexOfPage));
            setVisibilityOfPageButtons();
        }

        private void btn_Weiter_Click(object sender, EventArgs e)
        {

        }

        private void btn_Zurueck_Click(object sender, EventArgs e)
        {

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
