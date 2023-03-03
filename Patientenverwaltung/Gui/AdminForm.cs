using Patientenverwaltung.Model;
using System;
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
            if (validateInput())
            {
                try
                {
                    controller.createArzt(getArztFromForm());
                    MessageBox.Show("Arzt hinzugefügt!");
                    controller.navAdminToLogin();
                }catch(Exception ex)
                {
                    MessageBox.Show("Arzt konnte nicht erstellt werden! Bitte Eingabe überprüfen.");
                    Console.WriteLine(ex.Message);
                }
            } else
            {
                MessageBox.Show("Bitte alle Felder füllen!");
            }
        }

        private Arzt getArztFromForm()
        {
            return new Arzt
            {
                adresse = new Adresse()
                {
                    ort = txt_Ort.Text,
                    hausnummer = txt_HausNr.Text,
                    plz = Convert.ToInt32(txt_PLZ.Text),
                    straße = txt_Straße.Text
                },
                vorname = txt_Vorname.Text,
                nachname = txt_Nachname.Text,
                email = txt_Mail.Text,
                telefonnummer = txt_TelNr.Text,
                geburtstag = Convert.ToDateTime(txt_Geburtstag.Text),
                titel = txt_Titel.Text,
                passwortInformation = new PasswordInformation(txt_Passwort.Text),
                idFachgebiet = Convert.ToInt32(txt_Fachgebiet.Text)
            };
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            controller.navAdminToLogin();
        }

        private bool validateInput()
        {
            return !(txt_Vorname.Text == "" || txt_Nachname.Text == "" || txt_Mail.Text == "" || txt_TelNr.Text == "" || txt_Geburtstag.Text == "" ||
                txt_Straße.Text == "" || txt_HausNr.Text == "" || txt_Ort.Text == "" || txt_PLZ.Text == "" ||
                txt_Titel.Text == "" || txt_Passwort.Text == "" || txt_Fachgebiet.Text == "");
        }
        public void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
