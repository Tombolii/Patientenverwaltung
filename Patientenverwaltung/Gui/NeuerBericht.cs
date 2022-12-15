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
    public partial class NeuerBericht : Form
    {
        public NeuerBericht()
        {
            InitializeComponent();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bericht berichtForm = new Bericht();
            berichtForm.Show();
        }
    }
}
