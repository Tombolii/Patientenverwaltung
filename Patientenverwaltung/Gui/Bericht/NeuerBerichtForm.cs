using System;
using Patientenverwaltung.Model;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Patientenverwaltung.Gui
{
    public partial class NeuerBerichtForm : Form
    {
        private Controller controller;

        public NeuerBerichtForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                displayDiagnoseDropdown();
            }
        }

        private void btn_BerhichtHinzufuegen_Click(object sender, EventArgs e)
        {
                try
                {
                    controller.createBericht(getBerichtFromForm());
                    controller.navNeuerBerichtToTerminDaten();
                    MessageBox.Show("Der Bericht wurde hinzugefügt!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Es konnte kein Bericht hinzugefügt werden!");
                }
        }

        /// <summary>
        /// Holt die Daten des neuen Berichts aus der Form
        /// </summary>
        /// <returns>neuer Bericht</returns>
        private Bericht getBerichtFromForm()
        {
            Bericht neuerBericht = new Bericht();
            Termin currentTermin = controller.getCurrentSelectedTermin();
            neuerBericht.idPatient = currentTermin.simplePatient.idPatient;
            neuerBericht.zeitpunkt = currentTermin.zeitpunkt;
            neuerBericht.beschwerden = txt_Beschwerden.Text;
            neuerBericht.bemerkung = txt_Bemerkungen.Text;
            string[] diagnoseSplits = boxDiagnose.Text.Split(':');
            neuerBericht.diagnose = new Krankheitsbild()
            {
                idKrankheitsbild = Convert.ToInt32(diagnoseSplits[0]),
                bezeichnung = diagnoseSplits[1].Trim()
            };
            return neuerBericht;
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navNeuerBerichtToTerminDaten();
        }

        /// <summary>
        /// Füllt das DiagnoseDropdown
        /// </summary>
        private void displayDiagnoseDropdown()
        {
            foreach (var krankheitsbild in controller.getKrankheitsbilder())
            {
                boxDiagnose.Items.Add(krankheitsbild.idKrankheitsbild + ": " + krankheitsbild.bezeichnung);
            }
        }
    }
}