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

    public partial class Login : Form
    {

        private Label lblBenutzername;
        private Label lblPasswort;
        private TextBox txtBenutzername;
        private TextBox txtPasswort;
        private Button btnLogin;
        private ErrorProvider errorProvider;
        private Controller controller;

        public Login(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string id = txtBenutzername.Text;
            string passwort = txtPasswort.Text;

            // Hier würde man normalerweise die Benutzerdaten gegen eine Datenbank oder ein anderes Authentifizierungssystem prüfen
            // Wir simulieren das hier einfach mal mit einem festen Benutzernamen und Passwort
            if (id == "admin" && passwort == "geheim")
            {
                controller.programmStart();
            }
            else
            {
                errorProvider.SetError(btnLogin, "Ungültige Anmeldeinformationen");
            }
        }
    }
}
