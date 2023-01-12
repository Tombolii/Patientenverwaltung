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
    public partial class BerichtBearbeiten : Form
    {
        public BerichtBearbeiten()
        {
            InitializeComponent();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Controller.showBericht();
        }

        private void btn_AenderungUebernehmen_Click(object sender, EventArgs e)
        {
            Controller.showBericht();
        }
    }
}
