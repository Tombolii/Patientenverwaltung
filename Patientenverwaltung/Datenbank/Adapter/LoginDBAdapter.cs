using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;

namespace Patientenverwaltung.Datenbank.Adapter
{
    /// <summary>
    /// Verwalten von LoginDaten
    /// </summary>
    public class LoginDBAdapter : BaseDBAdapter
    {

        /// <summary>
        /// Das Password des gesuchten Arztes wird von der Datenbank ausgegeben
        /// </summary>
        /// <param name="arztID">der Arzt</param>
        /// <returns>PasswordInformationen des Arztes</returns>
        public PasswordInformation getPassword(int arztID)
        {
            string sql = "SELECT password, password_salt FROM Arzt WHERE idArzt = '" + arztID + "';";

            MySqlDataReader reader = connector.executeQuery(sql);
            PasswordInformation passwordInformation = new PasswordInformation();
            while (reader.Read())
            {
                passwordInformation.password = reader.GetString("password");
                passwordInformation.passwordSalt = reader.GetString("password_salt");
            }
            reader.Close();
            return passwordInformation;
        }
    }
}
