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
    public partial class BerichtBearbeiten : Form
    {
        public BerichtBearbeiten()
        {
            InitializeComponent();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Hide();
            BerichtDaten berichtDaten = new BerichtDaten();
            berichtDaten.Show();
        }
    }
}
