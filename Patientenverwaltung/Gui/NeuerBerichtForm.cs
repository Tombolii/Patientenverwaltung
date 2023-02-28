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
            neuerBericht.idPatient = controller.getCurrentSelectedTermin().simplePatient.idPatient;
            neuerBericht.beschwerden = txt_Beschwerden.Text;
            neuerBericht.bemerkung = txt_Bemerkungen.Text;
            neuerBericht.diagnose = new Krankheitsbild()
            {
                idKrankheitsbild = 1
            };

            try
            {
                controller.navNeuerBerichtToTerminDaten(neuerBericht);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navNeuerBerichtToTerminDaten();
        }
    }
}
