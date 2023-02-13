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
    public partial class PatientenDaten : Form
    {
        private Controller controller;

        public PatientenDaten(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btn_PatientBearbeiten_Click(object sender, EventArgs e)
        {
            controller.patientDatenChangePat();
        }

        private void btn_Berichte_Click(object sender, EventArgs e)
        {
            controller.patientDatenOpenBerichte();
        }

        private void btn_Zurueck_Click(object sender, EventArgs e)
        {
            controller.patientDatenBack();
        }
    }
}
