using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientenverwaltungOberfläche
{
    public partial class Bericht : Form
    {
        public Bericht()
        {
            InitializeComponent();
        }

        private void btn_BerichtHinzufuegen_Click(object sender, EventArgs e)
        {
            this.Hide();
            NeuerBericht addBericht = new NeuerBericht();
            addBericht.Show();
        }

        private void btn_Startseite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patienten patientForm = new Patienten();
            patientForm.Show();
        }
    }
}
