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
            int patID  = Convert.ToInt32(this.txt_ID.Text);
            int patArztID = Convert.ToInt32(this.txt_arztID.Text);
            String terminZeitpunkt = this.txt_Datum.Text + " " + this.txt_Uhrzeit.Text;

            Termin newTermin = new Termin();
            newTermin.zeitpunkt = Convert.ToDateTime(terminZeitpunkt);
            newTermin.simplePatient = new SimplePatient() { idPatient = patID };
            newTermin.arzt = new Arzt() { idArzt = patArztID };


            controller.neuerTerminAddTermin(newTermin);
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.neuerTerminClose();
        }

        private void NeuerTermin_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {

        }
    }
}
