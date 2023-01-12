using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller = Patientenverwaltung.Controller;

namespace Patientenverwaltung.Gui
{
    
    public partial class Programmstart : Form
    {

        public Programmstart()
        {
            InitializeComponent();
        }

        private void btn_TerminHinzufuegen_Click(object sender, EventArgs e)
        {
            Controller.addTermin();
        }

        private void btn_PatientenAnsehen_Click(object sender, EventArgs e)
        {
            Controller.Patient();
        }
    }
}
