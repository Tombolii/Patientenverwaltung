using System;
using Patientenverwaltung.Model;
using System.Windows.Forms;

namespace Patientenverwaltung.Gui
{
    public partial class TerminDatenForm : Form
    {
        private Controller controller;

        public TerminDatenForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                displayTerminDaten();
                setUpBericht();
            }
        }

        private void btn_TerminBearbeiten_Click(object sender, EventArgs e)
        {
            controller.navTerminDatenToTerminBearbeiten();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navTerminDatenToArztOverview();
        }

        private void btn_TerminLoeschen_Click(object sender, EventArgs e)
        {
            controller.navTerminDatenToDeleteTerminConfirmationPopup();
        }

        private void displayTerminDaten()
        {
            
            Termin termin = controller.getCurrentSelectedTermin();
            txt_Nachname.Text = termin.simplePatient.nachname;
            txt_Vorname.Text = termin.simplePatient.vorname;
            txt_Datum.Text = termin.zeitpunkt.ToShortDateString();
            txt_Uhrzeit.Text = termin.zeitpunkt.ToShortTimeString();
        }

        /// <summary>
        /// Überprüft ob bereits ein Bericht vorhanden ist, wenn nicht wird Button entsprechend benannt
        /// </summary>
        private void setUpBericht()
        {
            if(controller.getCurrentSelectedTermin().idBericht == 0)
            {
                btnBericht.Text = "Bericht erstellen";
            }
            else
            {
                btnBericht.Text = "Bericht anzeigen";
            }
        }

        private void btnBericht_Click(object sender, EventArgs e)
        {
            if(btnBericht.Text == "Bericht erstellen")
            {
                controller.navTerminDatenToNeuerBericht();
            }
            else
            {
                Bericht bericht = controller.getCurrentSelectedBericht();
                controller.setCurrentSelectedBericht(bericht);
                controller.navTerminDatenToBerichtDaten();
            }
        }
        public void TerminDatenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
