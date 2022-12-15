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
    public partial class PatientDatenForm : Form
    {
        public PatientDatenForm()
        {
            InitializeComponent();
        }

        private void btn_PatientBearbeiten_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientBearbeiten bearbeitePatient = new PatientBearbeiten();
            bearbeitePatient.Show();
        }

        private void btn_Berichte_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bericht BerichtForm = new Bericht();
            BerichtForm.Show();
        }

        private void btn_Zurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patienten patientForm = new Patienten();
            patientForm.Show();
        }
    }
}
