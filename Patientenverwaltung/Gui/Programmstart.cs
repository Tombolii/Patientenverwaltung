using Patientenverwaltung.Model;
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
        private Controller controller;
        private static int rowCount = 0;
        public Programmstart(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;

        }

        private void btn_TerminHinzufuegen_Click(object sender, EventArgs e)
        {
            controller.ärzteseiteAddTermin();
        }

        private void btn_PatientenAnsehen_Click(object sender, EventArgs e)
        {
            controller.ärzteseiteSearchPat();
        }

        private void Programmstart_Load(object sender, EventArgs e)
        {
            
        }

        public void displayAllTermine()
        {
            List<Termin> termine = controller.GetTermineOfArzt(1);
            for (int i = 0; i < termine.Count; i++)
            {
                addTerminToFrontend(termine[i]);
            }
        }
        public void addTerminToFrontend(Termin termin)
        {
                tblTermine.Controls.Add(new Label() { Text = termin.patient.nachname }, 2, rowCount);
                tblTermine.Controls.Add(new Label() { Text = termin.patient.vorname }, 3, rowCount);
                tblTermine.Controls.Add(new Label() { Text = termin.zeitpunkt.ToString("dd,MM,yyyy") }, 0, rowCount);
                tblTermine.Controls.Add(new Label() { Text = termin.zeitpunkt.ToString("H:mm") + " Uhr" }, 1, rowCount);
                rowCount++;
        }

    }
}
