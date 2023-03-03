using System;
using Patientenverwaltung.Model;
using System.Windows.Forms;

namespace Patientenverwaltung.Gui
{
    public partial class TerminBearbeitenForm : Form
    {
        private Controller controller;

        public TerminBearbeitenForm(Controller controller)
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
            }
        }

        private void btn_AenderungUebernehmen_Click(object sender, EventArgs e)
        {
            try
            {
                controller.updateTermin(getTerminFromForm());
                controller.navTerminBearbeitenToTerminDaten();
                MessageBox.Show("Termin wurde bearbeitet!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Termin konnte nicht bearbeitet werden!");
            }
        }

        /// <summary>
        /// Holt die neuen Daten des Termins aus der Form
        /// </summary>
        /// <returns>aktualisierten Termin</returns>
        private Termin getTerminFromForm()
        {
            Termin updatedTermin = controller.getCurrentSelectedTermin();
            updatedTermin.zeitpunkt = Convert.ToDateTime(txt_Datum.Text + " " + txt_Uhrzeit.Text);
            return updatedTermin;
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navTerminBearbeitenToTerminDaten();
        }

        private void displayTerminDaten()
        {
            Termin termin = controller.getCurrentSelectedTermin();
            txt_Datum.Text = termin.zeitpunkt.ToShortDateString();
            txt_Uhrzeit.Text = termin.zeitpunkt.ToShortTimeString();
        }

        public void TerminBearbeitenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
