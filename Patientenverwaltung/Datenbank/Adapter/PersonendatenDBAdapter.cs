using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Datenbank.Adapter
{
    public class PersonendatenDBAdapter: BaseDBAdapter
    {
        /// <summary>
        /// Legt einen neuen Personendatensatz in der Datenbank an
        /// </summary>
        /// <param name="personendaten">die angelegt werden sollen</param>
        /// <returns>die erstellten Personendaten</returns>
        public Personendaten createNewPersonendaten(Personendaten personendaten, int idAdresse)
        {
            string sql = "INSERT into personendaten (vorname, nachname, email, telefonnummer, geburtstag, idAdresse) " +
            "VALUES('" + personendaten.vorname + "', '" +
            personendaten.nachname + "', '" +
            personendaten.email + "', '" +
            personendaten.telefonnummer + "', '" +
            personendaten.geburtstag.Date + "', " +
            idAdresse + "); " +
            "SELECT LAST_INSERT_ID() as 'idPersonendaten';";
            MySqlDataReader reader = connector.executeQuery(sql);
            reader.Read();
            personendaten.idPersonendaten = reader.GetInt32("idPersonendaten");
            reader.Close();
            return personendaten;
        }

        /// <summary>
        /// Aktualisiert einen Personendatensatz in der Datenbank
        /// </summary>
        /// <param name="personendaten">die aktualisiert werden sollen</param>
        /// <returns>die aktualisierten Personendaten</returns>
        public Personendaten updatePersonendaten(Personendaten personendaten)
        {
            string sql = "UPDATE personendaten " +
            "SET vorname = '" + personendaten.vorname + "', " +
            "nachname = '" + personendaten.nachname + "', " +
            "email = '" + personendaten.email + "', " +
            "telefonnummer = '" + personendaten.telefonnummer + "', " +
            "geburtstag = '" + personendaten.geburtstag + "' " +
            "WHERE idPersonendaten = " + personendaten.idPersonendaten + ";";
            connector.executeNonQuery(sql);
            return personendaten;
        }
    }
}
