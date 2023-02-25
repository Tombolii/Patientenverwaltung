using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patientenverwaltung.Model;

namespace Patientenverwaltung.Gui
{

    public partial class LoginForm : Form
    {

        private Label lblArztId;
        private Label lblPasswort;
        private TextBox txtArztId;
        private TextBox txtPasswort;
        private Button btnLogin;
        private ErrorProvider errorProvider;
        private Controller controller;

        public LoginForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtArztId.Text);
            string passwort = txtPasswort.Text;

            // Hier würde man normalerweise die Benutzerdaten gegen eine Datenbank oder ein anderes Authentifizierungssystem prüfen
            // Wir simulieren das hier einfach mal mit einem festen Benutzernamen und Passwort
            if (passwort == "geheim")
            {
                controller.navLoginToArztOverview(id);
            }
            else
            {
                errorProvider.SetError(btnLogin, "Ungültige Anmeldeinformationen");
            }
        }
    }
}
