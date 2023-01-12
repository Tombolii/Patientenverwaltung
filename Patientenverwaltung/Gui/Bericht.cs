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
        
        public Bericht()
        {
            InitializeComponent();
        }

        private void btn_BerichtHinzufuegen_Click(object sender, EventArgs e)
        {
            Controller.addBericht();
        }

        private void btn_BerichtSuchen_Click(object sender, EventArgs e)
        {
            Controller.showBericht();
        }

        private void btn_Startseite_Click(object sender, EventArgs e)
        {
            Controller.Patient();
        }
    }
}
