using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Patientenverwaltung.Model
{
    public class PasswordInformation
    {
        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _passwordSalt;

        public string passwordSalt
        {
            get { return _passwordSalt; }
            set { _passwordSalt = value; }
        }

        public PasswordInformation()
        {

        }

        public PasswordInformation(String passwordInput) {
            generatePasswordInformation(passwordInput);
        }

        /// <summary>
        /// Überprüft ob die gegebenen Passwörter übereinstimmen
        /// </summary>
        /// <param name="passwordInput">Zu überprüfende Passwort</param>
        /// <returns>true bei Übereinstimmung</returns>
        public bool validatePassword(string passwordInput)
        {
            SHA256 encryptor = SHA256.Create();

            // Hashen des Passworts mit Salt
            byte[] passwordInputBytes = Encoding.UTF8.GetBytes(passwordInput);
            byte[] passwordSaltBytes = Convert.FromBase64String(_passwordSalt);
            byte[] saltedPasswordBytes = passwordInputBytes.Concat(passwordSaltBytes).ToArray();
            byte[] saltedPasswordHashBytes = encryptor.ComputeHash(saltedPasswordBytes);

            // Überprüfen ob Passwörter übereinstimmen
            return _password.Equals(Convert.ToBase64String(saltedPasswordHashBytes));
        }

        private void generatePasswordInformation(String passwordInput)
        {
            // Generierung des Passwort-Salts
            byte[] passwordSaltBytes = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(passwordSaltBytes);
            }

            SHA256 encryptor = SHA256.Create();

            // Hashen des Passworts mit Salt
            byte[] passwordInputBytes = Encoding.UTF8.GetBytes(passwordInput);
            byte[] saltedPasswordBytes = passwordInputBytes.Concat(passwordSaltBytes).ToArray();
            byte[] saltedPasswordHashBytes = encryptor.ComputeHash(saltedPasswordBytes);

            password = Convert.ToBase64String(saltedPasswordHashBytes);
            passwordSalt = Convert.ToBase64String(passwordSaltBytes);
        }   
    }
}
