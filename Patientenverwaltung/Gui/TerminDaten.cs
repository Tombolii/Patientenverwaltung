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
    public partial class TerminDaten : Form
    {
        private Controller controller;

        public TerminDaten(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btn_TerminBearbeiten_Click(object sender, EventArgs e)
        {
            controller.terminDatenChangeTermin();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.terminDatenClose();
        }

        private void btn_TerminLoeschen_Click(object sender, EventArgs e)
        {
            controller.terminDatenDeleteTermin();
        }
    }
}
