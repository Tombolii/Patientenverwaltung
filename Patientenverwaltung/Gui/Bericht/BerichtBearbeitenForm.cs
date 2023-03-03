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
            }
            else
            {
                controller.navBerichtBearbeitenToBerichtOverview();
            }
        }

        private void btn_AenderungUebernehmen_Click(object sender, EventArgs e)
        {
                try
                {
                    controller.updateBericht(getBerichtFromForm());
                    if (isNavigatedFromTerminDaten())
                    {
                        controller.navBerichtBearbeitenToTerminDaten();
                    }
                    else
                    {
                        controller.navBerichtBearbeitenToBerichtOverview();
                    }
                    MessageBox.Show("Bericht wurde bearbeitet!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Bericht konnte nicht bearbeitet werden! Bitte Eingabe überprüfen.");
                }
        }

        /// <summary>
        /// Holt die neuen Daten des Berichts aus der Form
        /// </summary>
        /// <returns>aktualisierten Bericht</returns>
        private Bericht getBerichtFromForm()
        {
            Bericht updatedBericht = controller.getCurrentSelectedBericht();
            updatedBericht.beschwerden = txt_Beschwerden.Text;
            updatedBericht.bemerkung = txt_Bemerkungen.Text;
            string[] diagnoseSplits = boxDiagnose.Text.Split(':');
            updatedBericht.diagnose = new Krankheitsbild()
            {
                idKrankheitsbild = Convert.ToInt32(diagnoseSplits[0]),
                bezeichnung = diagnoseSplits[1].Trim()
            };
            return updatedBericht;
        }

        private void displayBerichtDaten()
        {
            Bericht currentBericht = controller.getCurrentSelectedBericht();
            txtUhrzeit.Text = currentBericht.zeitpunkt.ToShortDateString();
            txtDatum.Text = currentBericht.zeitpunkt.ToShortTimeString();
            txt_Bemerkungen.Text = currentBericht.bemerkung;
            txt_Beschwerden.Text = currentBericht.beschwerden;
            displayDiagnoseDropdown();
            boxDiagnose.Text = currentBericht.diagnose.idKrankheitsbild + ": " + currentBericht.diagnose.bezeichnung;
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

        public void BerichtBearbeitenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
