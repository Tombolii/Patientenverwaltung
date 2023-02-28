using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Datenbank.Adapter
{
    public class TerminDBAdapter: BaseDBAdapter
    {

        /// <summary>
        /// Legt einen neuen Termin in der Datenbank an
        /// </summary>
        /// <param name="termin">neuer Termin, der angelegt werden soll</param>
        /// <returns>neu angelegte Termin</returns>
        public Termin addTermin(Termin termin)
        {
            string sql = "INSERT INTO termin (zeitpunkt, idArzt, idPatient) " +
            "VALUES ('" + termin.zeitpunkt.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
            termin.idArzt + ", " + termin.simplePatient.idPatient + "); " +
            "SELECT LAST_INSERT_ID() as 'idTermin';";

            MySqlDataReader reader = connector.executeQuery(sql);
            reader.Read();
            termin.idTermin = reader.GetInt32("idTermin");
            reader.Close();
            return termin;
        }

        /// <summary>
        /// ktualisiert einen Termin in der Datenbank
        /// </summary>
        /// <param name="termin">aktualisierter Termin</param>
        /// <returns>den aktualisierten Termin</returns>
        public Termin modifyTermin(Termin termin)
        {
            string sql = "UPDATE termin SET zeitpunkt = '" + termin.zeitpunkt.ToString() + "' WHERE idTermin = " + termin.idTermin + ";";
            connector.executeNonQuery(sql);
            return termin;
        }

        /// <summary>
        /// Löscht einen Termin aus der Datenbank
        /// </summary>
        /// <param name="termin">der gelöscht werden soll</param>
        public void deleteTermin(Termin termin)
        {
            {
            string sql = "DELETE FROM termin WHERE idTermin = " + termin.idTermin + ";";
            connector.executeQuery(sql);
            }
        }

        /// <summary>
        /// Liest alle Termine eines Arztes aus der Datenbank
        /// </summary>
        /// <param name="idArzt">des Arztes</param>
        /// <returns>Liste aller Termine</returns>
        public List<Termin> getTermineOfArzt(int idArzt)
        {
            string condition = "WHERE idArzt = " + idArzt;
            return getTermine(condition);
        }

        /// <summary>
        /// Liest alle Termine eines Patienten aus der Datenbank
        /// </summary>
        /// <param name="idPatient">des Patienten</param>
        /// <returns>Liste aller Termine</returns>
        public List<Termin> getTermineOfPatient(int idPatient)
        {
            string condition = "WHERE idPatient = " + idPatient;
            return getTermine(condition);
        }

        private List<Termin> getTermine(string condition)
        {
            string sql = "SELECT termin.idTermin, termin.zeitpunkt, termin.idPatient, termin.idArzt, personendaten.vorname, " +
                "personendaten.nachname, patient.idPatient, termin.idBericht " +
                "FROM termin " +
                "INNER JOIN patient ON termin.idPatient = patient.idPatient " +
                "INNER JOIN personendaten ON patient.idPersonendaten = personendaten.idPersonendaten " +
                condition + " order by zeitpunkt;";
            MySqlDataReader reader = this.connector.executeQuery(sql);
            List<Termin> termine = new List<Termin>();
            while (reader.Read())
            {
                Termin termin = new Termin();
                termin.idTermin = reader.GetInt32("idTermin");
                termin.zeitpunkt = DateTime.Parse(reader.GetString("zeitpunkt"));
                termin.simplePatient = new SimplePatient()
                {
                    idPatient = reader.GetInt32("idPatient"),
                    vorname = reader.GetString("vorname"),
                    nachname = reader.GetString("nachname")
                };
                termin.idArzt = reader.GetInt32("idArzt");
                if (!reader.IsDBNull(reader.GetOrdinal("idBericht")))
                {
                   termin.idBericht = reader.GetInt32("idBericht");
                }
                termine.Add(termin);
            }
            reader.Close();
            return termine;
        }
    }
}
