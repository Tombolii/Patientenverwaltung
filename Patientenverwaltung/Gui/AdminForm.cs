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

namespace Patientenverwaltung.Gui
{
    public partial class AdminForm : Form
    {

        private Controller controller;

        public AdminForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Adresse newAdresse = new Adresse();
            newAdresse.ort = txt_Ort.Text;
            newAdresse.hausnummer = txt_HausNr.Text;
            newAdresse.plz = Convert.ToInt32(txt_PLZ.Text);
            newAdresse.straße = txt_Straße.Text;

            Arzt newArzt = new Arzt();
            newArzt.adresse = newAdresse;
            newArzt.vorname = txt_Vorname.Text;
            newArzt.nachname = txt_Nachname.Text;
            newArzt.email = txt_Mail.Text;
            newArzt.telefonnummer = txt_TelNr.Text;
            newArzt.geburtstag = Convert.ToDateTime(txt_Geburtstag.Text);
            newArzt.titel = txt_Titel.Text;
            newArzt.passwort = txt_Passwort.Text;
            newArzt.idFachgebiet = Convert.ToInt32(txt_Fachgebiet.Text);



            if (txt_Vorname.Text == " " || txt_Nachname.Text == " " || txt_Mail.Text == " " || txt_TelNr.Text == " " || txt_Geburtstag.Text == " " ||
                txt_Straße.Text == " " || txt_HausNr.Text == " " || txt_Ort.Text == " " || txt_PLZ.Text == " " ||
                txt_Titel.Text == " " || txt_Passwort.Text == " " || txt_Fachgebiet.Text == " ")
            {
                MessageBox.Show("Fehlerhafte Eingabe");
            }
            else
            {
                controller.createArzt(newArzt);
                MessageBox.Show("Arzt hinzugefügt!");
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            controller.navAdminToLogin();
        }

        private void txt_Fachgebiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
