using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;

namespace Patientenverwaltung.Gui
{
    public partial class BerichtBearbeitenForm : Form
    {
        private Controller controller;

        public BerichtBearbeitenForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                displayBerichtDaten();
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            if(isNavigatedFromTerminDaten())
            {
                controller.navBerichtBearbeitenToTerminDaten();
                MessageBox.Show("Nichts bearbeitet!");
            }
            else
            {
                controller.navBerichtBearbeitenToBerichtOverview();
                MessageBox.Show("Nichts bearbeitet!");
            }
        }

        private void btn_AenderungUebernehmen_Click(object sender, EventArgs e)
        {
            Bericht updatedBericht = controller.getCurrentSelectedBericht();
            updatedBericht.beschwerden = txt_Beschwerden.Text;
            updatedBericht.bemerkung = txt_Bemerkungen.Text;
            // TODO: Diagnose updaten 
            try
            {
                controller.updateBericht(updatedBericht);
                if (isNavigatedFromTerminDaten())
                {
                    controller.navBerichtBearbeitenToTerminDaten();
                    MessageBox.Show("Bericht wurde bearbeitet!");
                }
                else
                {
                    controller.navBerichtBearbeitenToBerichtOverview();
                    MessageBox.Show("Bericht wurde bearbeitet!");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Bericht konnte nicht bearbeitet werden!");
            }
        }

        private void displayBerichtDaten()
        {
            Bericht currentBericht = controller.getCurrentSelectedBericht();
            txtUhrzeit.Text = currentBericht.zeitpunkt.ToShortDateString();
            txtDatum.Text = currentBericht.zeitpunkt.ToShortTimeString();
            txt_Bemerkungen.Text = currentBericht.bemerkung;
            txt_Beschwerden.Text = currentBericht.beschwerden;
            txt_Diagnose.Text = currentBericht.diagnose.bezeichnung;
        }

        /// <summary>
        /// Überprüft ob die aufrufende Form die TerminDatenForm ist
        /// </summary>
        /// <returns>true, wenn TerminDatenForm aufrufende Form ist</returns>
        private bool isNavigatedFromTerminDaten()
        {
            foreach (Form openedForm in Application.OpenForms)
            {
                if(openedForm.Name == "TerminDatenForm" && openedForm.Visible)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
