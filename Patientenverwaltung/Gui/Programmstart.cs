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
        private List<Model.Termin> termine;
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
            
            termine = controller.GetTerminArzt(1);
            displayTermine();


        }

        private void displayTermine()
        {
            for (int i = 0; i < termine.Count; i++)
            {
                tblTermine.Controls.Add(new Label() { Text = termine[i].patient.nachname }, 2, i);
                tblTermine.Controls.Add(new Label() { Text=termine[i].patient.vorname }, 3, i);
                tblTermine.Controls.Add(new Label() { Text = termine[i].zeitpunkt.ToString("dd,MM,yyyy") }, 0, i);
                tblTermine.Controls.Add(new Label() { Text = termine[i].zeitpunkt.ToString("H:mm") + " Uhr"}, 1, i);
            }
        }
    }
}
