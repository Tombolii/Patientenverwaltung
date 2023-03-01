using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patientenverwaltung;
using System.Windows.Forms;
using Patientenverwaltung.Model;
using Patientenverwaltung.Datenbank;
using MySql.Data.MySqlClient;

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
            Patient selectedPatient = controller.getCurrentSelectedPatient();
            Termin newTermin = new Termin()
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
            try
            {
                controller.createTermin(newTermin);
                controller.navNeuerTerminToPatientenDaten();
                MessageBox.Show("Termin hinzugefügt!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Es konnte kein Termin hinzugefügt werden!");
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.navNeuerTerminToPatientenDaten();
            System.Windows.Forms.MessageBox.Show("Keinen Termin hinzugefügt!");
        }
    }
}
