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
            termin.idArzt + ", " + termin.idPatient + ");" +
            "SELECT LAST_INSERT_ID() as 'idTermin';";

            MySqlDataReader reader = connector.executeQuery(sql);
            reader.Read();
            termin.idTermin = reader.GetInt32("idTermin");
            reader.Close();
            return termin;
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
            string sql = "SELECT termin.idTermin, termin.zeitpunkt, termin.idPatient, termin.idArzt " +
                "FROM termin " +
                condition + " order by zeitpunkt;";
            MySqlDataReader reader = this.connector.executeQuery(sql);
            List<Termin> termine = new List<Termin>();
            while (reader.Read())
            {
                Termin termin = new Termin();
                termin.idTermin = reader.GetInt32("idTermin");
                termin.zeitpunkt = DateTime.Parse(reader.GetString("zeitpunkt"));
                termin.idPatient = reader.GetInt32("idPatient");
                termin.idArzt = reader.GetInt32("idArzt");
                termine.Add(termin);
            }
            reader.Close();
            return termine;
        }
    }
}
