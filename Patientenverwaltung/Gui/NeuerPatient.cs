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
        public NeuerPatient()
        {
            InitializeComponent();
        }

        private void btn_PatientHinzufuegen_Click(object sender, EventArgs e)
        {
            Controller.addPatient();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Controller.showPatienten();
        }
    }
}
