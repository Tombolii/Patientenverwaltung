using System;
using System.Windows.Forms;
using Patientenverwaltung.Model;

namespace Patientenverwaltung.Gui
{
    public partial class NeuerTerminForm : Form
    {
        private Controller controller;

        public NeuerTerminForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;

        }

        private void btn_TerminHinzufuegen_Click(object sender, EventArgs e)
        {
            try
            {
                controller.createTermin(getTerminFromForm());
                controller.navNeuerTerminToPatientenDaten();
                MessageBox.Show("Termin hinzugefügt!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Es konnte kein Termin hinzugefügt werden! Bitte Eingabe überprüfen.");
            }
        }

        /// <summary>
        /// Sammelt alle Daten des Termins aus der Form
        /// </summary>
        /// <returns>den Termin</returns>
        private Termin getTerminFromForm()
        {
            Patient selectedPatient = controller.getCurrentSelectedPatient();
            return new Termin()
            {
                idArzt = controller.getLoggedInArzt().idArzt,
                simplePatient = new SimplePatient()
                {
                    idPatient = selectedPatient.idPatient,
                    nachname = selectedPatient.nachname,
                    vorname = selectedPatient.vorname
                },
                zeitpunkt = Convert.ToDateTime(txt_Datum.Text + " " + txt_Uhrzeit.Text)
            };
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navNeuerTerminToPatientenDaten();
        }
    }
}
