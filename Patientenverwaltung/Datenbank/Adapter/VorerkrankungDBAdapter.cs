using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Patientenverwaltung.Datenbank.Adapter
{
    public class VorerkrankungDBAdapter: BaseDBAdapter
    {
        /// <summary>
        /// Liest alle Vorerkrankungen eines Patienten aus
        /// </summary>
        /// <param name="idPatient">dessen Vorerkrankungen aktualisiert werden sollen</param>
        /// <param name="updatedVorerkrankungen">aktualisierte Liste der Vorerkrankungen</param>
        /// <param name="currentVorerkrankungen">aktuelle Liste der Vorkerkrankungen</param>
        public void synchVorerkrankungenOfPatient(
            int idPatient, List<Krankheitsbild> updatedVorerkrankungen, List<Krankheitsbild> currentVorerkrankungen)
        {
            List<Krankheitsbild> newVorerkrankungen = new List<Krankheitsbild>();
            List<Krankheitsbild> deletedVorerkrankungen = new List<Krankheitsbild>();
            foreach (Krankheitsbild krankheitsbild in updatedVorerkrankungen)
            {
                if (!currentVorerkrankungen.Any(v => v.idKrankheitsbild == krankheitsbild.idKrankheitsbild)){
                    newVorerkrankungen.Add(krankheitsbild);
                }
            }
            foreach (Krankheitsbild krankheitsbild in currentVorerkrankungen)
            {
                if (!updatedVorerkrankungen.Any(v => v.idKrankheitsbild == krankheitsbild.idKrankheitsbild))
                {
                    deletedVorerkrankungen.Add(krankheitsbild);
                }
            }

            if (newVorerkrankungen != null && newVorerkrankungen.Count > 0)
            {
                // neue Vorerkrankungen in der DB aufnehmen
                addVorerkrankungToPatient(idPatient, newVorerkrankungen);
            }
            
            if (deletedVorerkrankungen != null && deletedVorerkrankungen.Count > 0)
            {
                // entfernte Vorerkrankungen in der DB entfernen
                deleteVoerkrankungenOfPatient(idPatient, deletedVorerkrankungen);
            }
        }

        /// <summary>
        /// Liest alle Vorerkrankungen eines Patienten aus
        /// </summary>
        /// <param name="idPatient">des Patienten</param>
        /// <returns>Liste aller Vorerkrankungen des Patienten</returns>
        public List<Krankheitsbild> getVorerkrankungenOfPatient(int idPatient)
        {
            List<Krankheitsbild> vorerkrankungen = new List<Krankheitsbild>();
            string sql = "SELECT krankheitsbild.idKrankheitsbild, bezeichnung, symptome " +
                 "FROM krankheitsbild " +
                 "INNER JOIN vorerkrankung ON krankheitsbild.idKrankheitsbild = vorerkrankung.idKrankheitsbild " +
                 "WHERE idPatient = " + idPatient + ";";

            MySqlDataReader reader = connector.executeQuery(sql);
            while (reader.Read())
            {
                Krankheitsbild vorerkrankung = new Krankheitsbild();
                vorerkrankung.idKrankheitsbild = reader.GetInt32("idKrankheitsbild");
                vorerkrankung.bezeichnung = reader.GetString("bezeichnung");
                vorerkrankung.symptome = reader.GetString("symptome");
                vorerkrankungen.Add(vorerkrankung);
            }
            reader.Close();
            return vorerkrankungen;
        }

        private List<Krankheitsbild> addVorerkrankungToPatient(int idPatient, List<Krankheitsbild> vorerkrankungen)
        {
            string sql = "INSERT INTO vorerkrankung (idPatient, idKrankheitsbild) " +
                         extractSqlValuesForVorerkrankungen(vorerkrankungen, idPatient) + ";";
            connector.executeNonQuery(sql);
            return vorerkrankungen;
        }   

        private void deleteVoerkrankungenOfPatient(int idPatient, List<Krankheitsbild> vorerkrankungen)
        {
            string sql = "DELETE FROM vorerkrankung " +
            "WHERE idPatient = " + idPatient +
            " AND idKrankheitsbild IN (" +
            String.Join(", ", vorerkrankungen.Select(item => item.idKrankheitsbild).ToList())
            + ");";
            connector.executeNonQuery(sql);
        }

        private string extractSqlValuesForVorerkrankungen(List<Krankheitsbild> vorerkrankungen, int idPatient)
        {
            string values = "VALUES ";
            for (int i = 0; i < vorerkrankungen.Count; i++)
            {
                values += "(" + idPatient + ", " + vorerkrankungen[i].idKrankheitsbild + ")";
                if (i < (vorerkrankungen.Count - 1))
                {
                    values += ", ";
                }
            }
            return values;
        }
    }
}
