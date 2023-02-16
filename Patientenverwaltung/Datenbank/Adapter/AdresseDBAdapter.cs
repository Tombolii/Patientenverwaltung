using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Datenbank.Adapter
{
    public class AdresseDBAdapter: BaseDBAdapter
    {
        /// <summary>
        /// Legt eine neue Adresse in der Datenbank an
        /// </summary>
        /// <param name="adresse">die angelegt werden soll</param>
        /// <returns>die angelegte Adresse</returns>
        public Adresse createNewAdresse(Adresse adresse)
        {
            string sql = "INSERT INTO adresse (straße, hausnummer, ort, plz) " +
            "VALUES('" + adresse.straße + "', '" +
            adresse.hausnummer + "', '" +
            adresse.ort + "', " +
            adresse.plz + "); " +
            "SELECT LAST_INSERT_ID() as 'idAdresse';";
            MySqlDataReader reader = connector.executeQuery(sql);
            reader.Read();
            adresse.idAdresse = reader.GetInt32("idAdresse");
            reader.Close();
            return adresse;
        }

        /// <summary>
        /// Aktualisiert eine Adresse in der Datenbank
        /// </summary>
        /// <param name="adresse">die aktualisiert werden soll</param>
        /// <returns>die aktualisierte Adresse</returns>
        public Adresse updateAdresse(Adresse adresse)
        {
            string sql = "UPDATE adresse " +
            "SET straße = '" + adresse.straße + "', " +
            "hausnummer = '" + adresse.hausnummer + "', " +
            "ort = '" + adresse.ort + "', " +
            "plz = " + adresse.plz + " " +
            "WHERE idAdresse = " + adresse.idAdresse + ";";
            connector.executeNonQuery(sql);
            return adresse;
        }

    }
}
