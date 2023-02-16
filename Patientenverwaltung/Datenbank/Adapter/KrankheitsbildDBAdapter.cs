using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Datenbank.Adapter
{
    public class KrankheitsbildDBAdapter: BaseDBAdapter
    {

        /// <summary>
        /// Holt aus der Datenbank alle Krankheitsbilder                        
        /// </summary>
        /// <returns>Liste aller Krankheitsbilder</returns>
        public List<Krankheitsbild> getKrankheitsbilder()
        {
            string sql = "SELECT * FROM krankheitsbild;";

            MySqlDataReader reader = connector.executeQuery(sql);
            List<Krankheitsbild> krankheitsbilder = new List<Krankheitsbild>();
            while (reader.Read())
            {
                Krankheitsbild krankheitsbild = new Krankheitsbild();
                krankheitsbild.idKrankheitsbild = reader.GetInt32("idKrankheitsbild");
                krankheitsbild.bezeichnung = reader.GetString("bezeichnung");
                krankheitsbild.symptome = reader.GetString("symptome");
                krankheitsbilder.Add(krankheitsbild);
            }
            reader.Close();
            return krankheitsbilder;
        }

        /// <summary>
        /// Aktualisiert ein Krankheitsbild in der Datenbank
        /// </summary>
        /// <param name="modifiedKrankheitsbild">aktualisierte Krankheitsbild</param>
        /// <returns>das aktualisierte Krankheitsbild</returns>
        public Krankheitsbild modifyKrankheitsbild(Krankheitsbild modifiedKrankheitsbild)
        {
            string sql = "UPDATE krankheitsbild " +
                "SET bezeichnung = '" + modifiedKrankheitsbild.bezeichnung + "', " +
                "symptome = '" + modifiedKrankheitsbild.symptome + "' " +
                "WHERE idKrankheitsbild = " + modifiedKrankheitsbild.idKrankheitsbild + ";";

            connector.executeNonQuery(sql);
            return modifiedKrankheitsbild;
        }

        /// <summary>
        /// Fügt ein neues Krankheitsbild in die Datenbank ein
        /// </summary>
        /// <param name="newKrankheitsbild">neue Krankheitsbild</param>
        /// <returns>das neue Krankheitsbild</returns>
        public Krankheitsbild createKrankheitsbild(Krankheitsbild newKrankheitsbild)
        {
            string sql = "INSERT INTO krankheitsbild (bezeichnung, symptome) " +
                "VALUES('" + newKrankheitsbild.bezeichnung + "', '" +
                newKrankheitsbild.symptome + "'); " +
                "SELECT LAST_INSERT_ID() as 'idKrankheitsbild'";

            MySqlDataReader reader = connector.executeQuery(sql);
            reader.Read();
            newKrankheitsbild.idKrankheitsbild = reader.GetInt32("idKrankheitsbild");
            reader.Close();
            return newKrankheitsbild;
        }

        /// <summary>
        /// Löscht ein Krankheitsbild in der Datenbank
        /// </summary>
        /// <param name="idKrankheitsbild">des zu löschenden Krankheitbilds</param>
        public void deleteKrankheitsbild(int idKrankheitsbild)
        {
            string sql = "DELETE FROM krankheitsbild WHERE idKrankheitsbild = " + idKrankheitsbild + ";";

            connector.executeNonQuery(sql);
        }
    }
}
