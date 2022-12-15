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
    public partial class Ärzteseite : Form
    {
        public Ärzteseite()
        {
            InitializeComponent();
        }

        private void btn_PatientenAnsehen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patienten patientForm = new Patienten();
            patientForm.Show();
        }

        private void btn_TerminHinzufuegen_Click(object sender, EventArgs e)
        {
            this.Hide();
            NeuerTermin addTermin = new NeuerTermin();
            addTermin.Show();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Ärzteseite
            // 
            this.ClientSize = new System.Drawing.Size(644, 346);
            this.Name = "Ärzteseite";
            this.ResumeLayout(false);

        }
    }
}
