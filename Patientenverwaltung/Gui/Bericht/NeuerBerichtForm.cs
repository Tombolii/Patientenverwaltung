using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btn_BerhichtHinzufuegen_Click(object sender, EventArgs e)
        {
            Bericht neuerBericht = new Bericht();
            Termin currentTermin = controller.getCurrentSelectedTermin();
            neuerBericht.idPatient = currentTermin.simplePatient.idPatient;
            neuerBericht.zeitpunkt = currentTermin.zeitpunkt;
            neuerBericht.beschwerden = txt_Beschwerden.Text;
            neuerBericht.bemerkung = txt_Bemerkungen.Text;
            neuerBericht.diagnose = new Krankheitsbild()
            {
                idKrankheitsbild = 1,
                bezeichnung = "ToBeReplaced"
            };

            try
            {
                controller.createBericht(neuerBericht);
                controller.navNeuerBerichtToTerminDaten();
                MessageBox.Show("Bericht hinzugefügt!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Es konnte kein Bericht hinzugefügt werden!");
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navNeuerBerichtToTerminDaten();
            System.Windows.Forms.MessageBox.Show("Keinen Bericht hinzugefügt!");
        }
    }
}
