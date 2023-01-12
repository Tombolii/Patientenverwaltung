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
    public partial class NeuerBericht : Form
    {
        public NeuerBericht()
        {
            InitializeComponent();
        }

        private void btn_BerhichtHinzufuegen_Click(object sender, EventArgs e)
        {
            Controller.addBericht();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Controller.showBericht();
        }
    }
}
