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

namespace Patientenverwaltung.Gui
{
    public partial class Bericht : Form
    {

        private Controller controller;
        public Bericht(Controller controller)
        {
            InitializeComponent();
            this.controller= controller;
        }

        private void btn_BerichtHinzufuegen_Click(object sender, EventArgs e)
        {
            controller.berichtAddBericht();
        }

        private void btn_BerichtSuchen_Click(object sender, EventArgs e)
        {
            controller.berichtSearchBericht();
        }

        private void btn_Startseite_Click(object sender, EventArgs e)
        {
            controller.berichtBackToPat();
        }
    }
}
