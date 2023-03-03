using System;
using System.Windows.Forms;

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
            try
            {
                int id = Convert.ToInt32(txtArztId.Text);
                string passwort = txtPasswort.Text;
                if(controller.verifyLogin(id, passwort))
                {
                    controller.navLoginToArztOverview(id);
                }
                else
                {
                    errorProvider.SetError(btnLogin, "Ungültige Anmeldeinformationen");
                }
                

            } catch (Exception ex)
            {
                errorProvider.SetError(btnLogin, "Ungültige Anmeldeinformationen");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtArztId.Text != "" && txtPasswort.Text != "")
            {
                int id = Convert.ToInt32(txtArztId.Text);
                string passwort = txtPasswort.Text;

                if (id == 666 && passwort == "Admin666")
                {
                    controller.navLoginToAdmin();
                }
                else
                {
                    errorProvider.SetError(btnAdmin, "Sie sind nicht berechtigt!");
                }
            }
            else
            {
                errorProvider.SetError(btnAdmin, "Bitte Admin-Daten eingeben");
            }
        }

        public void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false;
                Application.Exit();
            }
        }
        /*Code für die Überprüfung der Passwortsicherheit (Kann beim Registrieren benutzt werden)
         * private void btnRegister_Click_1(object sender, EventArgs e)
         * {
         * int id = Convert.ToInt32(txtArztId.Text);
         * string passwort = txtPasswort.Text;
         * if(passwort.Length > 8 &&
         * Regex.Match(passwort, @"[A-Z]+").Success && 
         * Regex.Match(passwort, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]").Success &&
         * Regex.Match(passwort, @"[a-z]+").Success)
         * { 
         * controller.navLoginToArztOverview(id);
         * }
         * else
         * {
         * errorProvider.SetError(btnLogin, "Ungültige Anmeldeinformationen");
         * }
         * }
         */
    }
}
