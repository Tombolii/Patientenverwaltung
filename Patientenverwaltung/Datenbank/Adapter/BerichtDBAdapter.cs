using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Datenbank.Adapter
{
    public class BerichtDBAdapter: BaseDBAdapter
    {

        /// <summary>
        /// Liest alle Berichte eines Patienten aus der Datenbank aus
        /// </summary>
        /// <param name="idPatient">des Patienten</param>
        /// <returns>Liste aller Berichte</returns>
        public List<Bericht> getBerichteOfPatient(int idPatient)
        {
            string sql = "SELECT bericht.idBericht, bericht.idPatient, bericht.beschwerden, bericht.bemerkung, bericht.diagnose, krankheitsbild.bezeichnung, krankheitsbild.symptome, termin.zeitpunkt " +
                "FROM bericht " +
                "INNER JOIN krankheitsbild ON bericht.diagnose = krankheitsbild.idKrankheitsbild " +
                "INNER JOIN termin ON bericht.idBericht = termin.idBericht " +
                "WHERE bericht.idPatient = " + idPatient + ";";

            MySqlDataReader reader = connector.executeQuery(sql);
            // TODO: Extract this to a mapper class
            List<Bericht> berichte = new List<Bericht>();
            while (reader.Read())
            {
                Bericht bericht = new Bericht();
                bericht.idBericht = reader.GetInt32("idBericht");
                bericht.beschwerden = reader.GetString("beschwerden");
                bericht.bemerkung = reader.GetString("bemerkung");
                Krankheitsbild diagnose = new Krankheitsbild
                {
                    idKrankheitsbild = reader.GetInt32("diagnose"),
                    bezeichnung = reader.GetString("bezeichnung"),
                    symptome = reader.GetString("symptome")
                };
                bericht.diagnose = diagnose;
                bericht.zeitpunkt = DateTime.Parse(reader.GetString("zeitpunkt"));
                berichte.Add(bericht);
            }
            reader.Close();
            return berichte;
        }

        /// <summary>
        /// Holte einen Bericht aus der Datenbank
        /// </summary>
        /// <param name="idBericht">des Berichts</param>
        /// <returns>den gesuchten Bericht</returns>
        public Bericht getBericht(int idBericht)
        {
            string sql = "SELECT bericht.idBericht, bericht.idPatient, bericht.beschwerden, " +
                "bericht.bemerkung, bericht.diagnose, krankheitsbild.bezeichnung, " +
                "krankheitsbild.symptome, termin.zeitpunkt FROM bericht " +
                "INNER JOIN krankheitsbild ON bericht.diagnose = krankheitsbild.idKrankheitsbild " +
                "INNER JOIN termin ON bericht.idBericht = termin.idBericht " +
                "WHERE bericht.idBericht = " + idBericht + ";";

            MySqlDataReader reader = connector.executeQuery(sql);
            Bericht bericht = new Bericht();
            while (reader.Read())
            {
                bericht.idBericht = reader.GetInt32("idBericht");
                bericht.beschwerden = reader.GetString("beschwerden");
                bericht.bemerkung = reader.GetString("bemerkung");
                Krankheitsbild diagnose = new Krankheitsbild
                {
                    idKrankheitsbild = reader.GetInt32("diagnose"),
                    bezeichnung = reader.GetString("bezeichnung"),
                    symptome = reader.GetString("symptome")
                };
                bericht.diagnose = diagnose;
                bericht.zeitpunkt = DateTime.Parse(reader.GetString("zeitpunkt"));

            }
            reader.Close();
            return bericht;
        }

        /// <summary>
        /// Aktualisiert einen Bericht in der Datenbank
        /// </summary>
        /// <param name="modifiedBericht">aktualisierter Bericht</param>
        /// <returns>den aktualisierten Bericht</returns>
        public Bericht modifyBericht(Bericht modifiedBericht)
        {
            string sql = "UPDATE bericht " +
                "SET beschwerden = '" + modifiedBericht.beschwerden + "', " +
                "bemerkung = '" + modifiedBericht.bemerkung + "', " +
                "diagnose = " + modifiedBericht.diagnose.idKrankheitsbild + " " +
                "WHERE idBericht = " + modifiedBericht.idBericht + ";";

            connector.executeNonQuery(sql);
            return modifiedBericht;
        }

        /// <summary>
        /// Fügt einen neuen Bericht in die Datenbank ein
        /// </summary>
        /// <param name="newBericht">der neue Bericht</param>
        /// <returns>der neu erstellte Bericht</returns>
        public Bericht addBericht(Bericht newBericht)
        {
            string sql = "INSERT INTO bericht (idPatient, beschwerden, bemerkung, diagnose) " +
                "VALUES(" + newBericht.idPatient + ", '" +
                newBericht.beschwerden + "', '" +
                newBericht.bemerkung + "', " +
                newBericht.diagnose.idKrankheitsbild + "); " +
                "SELECT LAST_INSERT_ID() as 'idBericht';";

            MySqlDataReader reader = connector.executeQuery(sql);
            reader.Read();
            newBericht.idBericht = reader.GetInt32("idBericht");
            reader.Close();
            return newBericht;
        }

        /// <summary>
        /// Löscht einen Bericht aus der Datenbank
        /// </summary>
        /// <param name="bericht">der gelöscht werden soll</param>
        public void deleteBericht(Bericht bericht)
        {
            string sql = "DELETE FROM bericht WHERE idBericht = " + bericht.idBericht + ";";

            connector.executeNonQuery(sql);
        }
    }
}
