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
    public partial class BerichtDaten_cs : Form
    {
        private Controller controller;

        public BerichtDaten_cs(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.berichtBearbeitenClose();
        }

        private void btn_BerhichtBearbeiten_Click(object sender, EventArgs e)
        {
            controller.berichtDatenChange();
        }
    }
}
