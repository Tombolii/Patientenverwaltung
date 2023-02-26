using System;
using System.Windows.Forms;
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
            controller.navBerichtBearbeitenToBerichtOverview();
        }

        private void btn_AenderungUebernehmen_Click(object sender, EventArgs e)
        {
            Bericht updatedBericht = controller.getCurrentSelectedBericht();
            updatedBericht.beschwerden = txt_Beschwerden.Text;
            updatedBericht.bemerkung = txt_Bemerkungen.Text;
            // TODO: Diagnose updaten 
            controller.navBerichtBearbeitenToBerichtOverview(updatedBericht);
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
    }
}
