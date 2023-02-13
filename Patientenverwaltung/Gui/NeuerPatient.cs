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
    public partial class NeuerPatient : Form
    {
        private Controller controller;

        public NeuerPatient(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btn_PatientHinzufuegen_Click(object sender, EventArgs e)
        {
            controller.addPatient();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            controller.showPatienten();
        }
    }
}
