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
    public partial class Patienten : Form
    {
        private Controller controller;

        public Patienten(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btn_Startseite_Click(object sender, EventArgs e)
        {
            controller.closePatient();
        }

        private void btn_PatientHinzufuegen_Click(object sender, EventArgs e)
        {
            controller.addPatient();
        }

        private void btn_PatientSuchen_Click(object sender, EventArgs e)
        {
            controller.showPatienten();
        }

        private void Patienten_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.closePatient();
        }
    }
}
