using System;
using Patientenverwaltung.Model;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            Termin updatedTermin = controller.getCurrentSelectedTermin();
            updatedTermin.zeitpunkt = Convert.ToDateTime(txt_Datum.Text + txt_Uhrzeit.Text);
            try
            {
                controller.updateTermin(updatedTermin);
                controller.navTerminBearbeitenToTerminDaten();
                MessageBox.Show("Termin wurde bearbeitet!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Termin konnte nicht bearbeitet werden!");
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navTerminBearbeitenToTerminDaten();
            MessageBox.Show("Termin wurde nicht bearbeitet!");
        }

        private void displayTerminDaten()
        {
            Termin termin = controller.getCurrentSelectedTermin();
            txt_Datum.Text = termin.zeitpunkt.ToShortDateString();
            txt_Uhrzeit.Text = termin.zeitpunkt.ToShortTimeString();
        }
    }
}
