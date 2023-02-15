using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;
using Patientenverwaltung.Gui;
using Bericht = Patientenverwaltung.Model.Bericht;

namespace Patientenverwaltung.Datenbank
{
    public class DBAdapter
    {

        public const string DB_NAME = "patientenverwaltung";
        public const string DB_PASSWORD = "";
        public const string DB_USER = "root";
        public const string DB_HOST = "localhost";

        DataReaderMapper mapper = new DataReaderMapper();

        MySQLConnector connector = new MySQLConnector(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);

        public Termin addTermin(Termin termin)
        {
            string sql = "INSERT INTO termin (zeitpunkt, idArzt, idPatient) " +
                "VALUES ('" + termin.zeitpunkt.ToString("yyyy-MM-dd HH:mm:ss") + "', " + 
                termin.arzt.idArzt + ", " + termin.patient.idPatient + ");" +
                "SELECT LAST_INSERT_ID() as 'idTermin';";

            MySqlDataReader reader = connector.executeQuery(sql);
            reader.Read();
            termin.idTermin = reader.GetInt32("idTermin");
            reader.Close();
            return termin;
        }

        public List<Termin> getTermineOfArzt(int idArzt)
        {
            string condition = "WHERE idArzt = " + idArzt;
            return getTermine(condition);
        }

        public List<Termin> getTermineOfPatient(int idPatient)
        {
            string condition = "WHERE idPatient = " + idPatient;
            return getTermine(condition);
        }
        public Arzt getArztById(int idArzt)
        {
            string sql = "SELECT arzt.idArzt, personendaten.vorname, personendaten.nachname, personendaten.email, personendaten.telefonnummer, " +
                "personendaten.geburtstag, adresse.straße, adresse.hausnummer, adresse.ort, adresse.plz, fachgebiet.bezeichnung, arzt.titel " +
                "FROM patient " +
                "INNER JOIN personendaten ON personendaten.idPersonendaten = arzt.idPersonendaten " +
                "INNER JOIN adresse ON adresse.idAdresse = personendaten.idAdresse " +
                "INNER JOIN fachgebiet ON fachgebiet.idFachgebiet = arzt.idFachgebiet " +
                "WHERE idArzt = " + idArzt + ";";

            MySqlDataReader reader = connector.executeQuery(sql);
            return mapper.extractArztFromReader(reader);
        }

        /// <summary>
        /// Liest einen Patient mit Hilfe der idPatient aus
        /// </summary>
        /// <param name="idPatient">
        /// Id des gesuchten Patienten
        /// </param>
        /// <returns>
        /// den gesuchten Patienten
        /// </returns>
        public Patient getPatient(int idPatient)
        {
            string condition = "WHERE idPatient = " + idPatient;
            return getPatientByCondition(condition)[0];
        }

        /// <summary>
        /// Liest alle Patienten mit einem bestimmten Nachnamen aus
        /// </summary>
        /// <param name="nachname">
        /// Nachname des gesuchten Patienten
        /// </param>
        /// <returns>
        /// Liste der Patienten mit dem gesuchten Nachnamen
        /// </returns>
        public List<Patient> getPatient(string nachname)
        {
            string condition = "WHERE nachname = '" + nachname + "'";
            return getPatientByCondition(condition);
        }

        public void deletePatient(int idPatient)
        {
            string sql = "DELETE FROM patient WHERE idPatient = " + idPatient + ";";
            connector.executeNonQuery(sql);
        }

        
        public Patient modifyPatient(Patient patient)
        {
            // Update adresse
            string sql = "UPDATE adresse " +
                "SET straße = '" + patient.adresse.straße + "', " +
                "hausnummer = '" + patient.adresse.hausnummer + "', " +
                "ort = '" + patient.adresse.ort + "', " +
                "plz = " + patient.adresse.plz + " " +
                "WHERE idAdresse = " + patient.adresse.idAdresse + ";";
            connector.executeNonQuery(sql);

            sql = "UPDATE personendaten " +
                "SET vorname = '" + patient.vorname + "', " +
                "nachname = '" + patient.nachname + "', " +
                "email = '" + patient.email + "', " +
                "telefonnummer = '" + patient.telefonnummer + "', " +
                "geburtstag = '" + patient.geburtstag + "' " +
                "WHERE idPersonendaten = " + patient.idPersonendaten + ";";
            connector.executeNonQuery(sql);

            sql = "UPDATE patient " +
                "SET versicherungsnummer = " + patient.versicherungsnummer + ", " +
                "idVersicherung = " + patient.versicherung.idVersicherung + " " +
                "WHERE idPatient = " + patient.idPatient + ";";

            connector.executeNonQuery(sql);
            List<Krankheitsbild> currentVorerkrankungen = getVorerkrankungenOfPatient(patient.idPatient);
            if (!patient.vorerkrankungen.Equals(currentVorerkrankungen))
            {
                synchVorerkrankungenOfPatient(patient.idPatient, patient.vorerkrankungen, currentVorerkrankungen);
            }
            return patient;
        }

        public Patient addPatient(Patient newPatient)
        {
            // Anlegen der Adresse
            string sql = "INSERT INTO adresse (straße, hausnummer, ort, plz) " +
                "VALUES('" + newPatient.adresse.straße + "', '" +
                newPatient.adresse.hausnummer + "', '" +
                newPatient.adresse.ort + "', " +
                newPatient.adresse.plz + "); " +
                "SELECT LAST_INSERT_ID() as 'idAdresse';";
            connector.executeNonQuery(sql);

            // Anlegen der Personendaten
            sql = "INSERT into personendaten (vorname, nachname, email, telefonnummer, geburtstag, idAdresse) " +
                "VALUES('" + newPatient.vorname + "', ' " +
                newPatient.nachname + "', '" +
                newPatient.email + "', '" +
                newPatient.telefonnummer + "', '" +
                newPatient.geburtstag + "', " +
                "LAST_INSERT_ID());";
            connector.executeNonQuery(sql);

            // Anlegen des Patienten und Auslesen der Id des neuen Patienten
            sql = "INSERT INTO patient (idVersicherung, idPersonendaten, versicherungsnummer) " +
                "VALUES(" + newPatient.versicherung.idVersicherung + ", " +
                "LAST_INSERT_ID(), " +
                newPatient.versicherungsnummer + "); " +
                "SELECT LAST_INSERT_ID() as 'idPatient'";
            MySqlDataReader reader = connector.executeQuery(sql);
            reader.Read();
            int idPatient = reader.GetInt32("idPatient");
            reader.Close();

            // Neu angelegten Patient auslesen und Vorerkrankungen synchronisieren
            Patient patient = getPatient(idPatient);
            synchVorerkrankungenOfPatient(patient.idPatient, newPatient.vorerkrankungen, new List<Krankheitsbild>());
            return patient;
        }

        public List<Bericht> getBerichteOfPatient(int idPatient)
        {
            string sql = "SELECT bericht.idPatient, bericht.beschwerden, bericht.bemerkung, krankheitsbild.bezeichnung, krankheitsbild.symptome, termin.zeitpunkt " +
                "FROM bericht " +
                "INNER JOIN krankheitsbild ON bericht.diagnose = krankheitsbild.idKrankheitsbild " +
                "INNER JOIN termin ON bericht.idBericht = termin.idBericht " +
                "WHERE idPatient = " + idPatient + ";";

            MySqlDataReader reader = connector.executeQuery(sql);
            List<Bericht> berichte = new List<Bericht>();
            while (reader.Read())
            {
                Bericht bericht = new Bericht();
                bericht.beschwerden = reader.GetString("beschwerden");
                bericht.bemerkung = reader.GetString("bemerkung");
                Krankheitsbild diagnose = new Krankheitsbild
                {
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

        public Bericht modifyBericht(Bericht modifiedBericht)
        {
            string sql = "UPDATE bericht " +
                "SET beschwerden = " + modifiedBericht.beschwerden + ", " +
                "bemerkung = " + modifiedBericht.bemerkung + ", " +
                "diagnose = " + modifiedBericht.diagnose.idKrankheitsbild + " " +
                "WHERE idBericht = " + modifiedBericht.idBericht + ";";

            connector.executeNonQuery(sql);
            return modifiedBericht;
        }

        public Bericht addBericht(Bericht newBericht)
        {
            string sql = "INSERT INTO bericht (idPatient, beschwerden, bemerkung, diagnose) " +
                "VALUES(" + newBericht.patient.idPatient + ", " +
                newBericht.beschwerden + ", " +
                newBericht.bemerkung + ", " +
                newBericht.diagnose.idKrankheitsbild + ";";

            connector.executeNonQuery(sql);
            return newBericht;
        }

        public void deleteBericht(Bericht bericht)
        {
            string sql = "DELETE FROM bericht WHERE idBericht = " + bericht.idBericht + ";";

            connector.executeNonQuery(sql);
        }

        // KRANKHEITSBILDER VERWALTEN ------------------------------------------------------
        // ---------------------------------------------------------------------------------

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
        public Krankheitsbild addKrankheitsbild(Krankheitsbild newKrankheitsbild)
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

        private List<Patient> getPatientByCondition(string condition)
        {
            string sql = "SELECT patient.idPatient, personendaten.vorname, personendaten.nachname, personendaten.email, personendaten.telefonnummer, " +
                "personendaten.geburtstag, adresse.idAdresse, adresse.straße, adresse.hausnummer, adresse.ort, adresse.plz, versicherung.name, versicherung.idVersicherung, patient.versicherungsnummer " +
                "FROM patient " +
                "INNER JOIN personendaten ON personendaten.idPersonendaten = patient.idPersonendaten " +
                "INNER JOIN adresse ON adresse.idAdresse = personendaten.idAdresse " +
                "INNER JOIN versicherung ON versicherung.idVersicherung = patient.idVersicherung " +
                condition + ";";

            MySqlDataReader reader = connector.executeQuery(sql);
            return mapper.extractPatientenFromReader(reader);
        }

        private List<Termin> getTermine(string condition)
        {
            string sql = "SELECT termin.idTermin, termin.zeitpunkt, termin.idPatient, termin.idArzt " +
                "FROM termin " +
                condition + ";";
            MySqlDataReader reader = this.connector.executeQuery(sql);
            List<Termin> termine = new List<Termin>();
            while (reader.Read())
            {
                Termin termin = new Termin();
                termin.idTermin = reader.GetInt32("idTermin");
                termin.zeitpunkt = DateTime.Parse(reader.GetString("zeitpunkt"));
                termin.patient = getPatient(reader.GetInt32("idPatient"));
                termin.arzt = getArztById(reader.GetInt32("idArzt"));
                termine.Add(termin);
            }
            reader.Close();
            return termine;


        }

        private List<Krankheitsbild> getVorerkrankungenOfPatient(int idPatient)
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

        private void synchVorerkrankungenOfPatient(
            int idPatient, List<Krankheitsbild> updatedVorerkrankungen, List<Krankheitsbild> currentVorerkrankungen)
        {
            List<Krankheitsbild> newVorerkrankungen = updatedVorerkrankungen.Except(currentVorerkrankungen).ToList();
            if (newVorerkrankungen != null && newVorerkrankungen.Count > 0)
            {
                // neue Vorerkrankungen in der DB aufnehmen
                string sql = "INSERT INTO vorerkrankung (idPatient, idKrankheitsbild) " +
                    extractSqlValuesForVorerkrankungen(newVorerkrankungen, idPatient) + ";";
                connector.executeNonQuery(sql);
            }
            List<Krankheitsbild> deletedVorerkrankungen = currentVorerkrankungen.Except(updatedVorerkrankungen).ToList();
            if (deletedVorerkrankungen != null && deletedVorerkrankungen.Count > 0)
            {
                // entfernte Vorerkrankungen in der DB entfernen
                string sql = "DELETE FROM vorerkrankung " +
                    "WHERE idPatient = " + idPatient + 
                    " AND idKrankheitsbild IN (" + 
                    String.Join(", ", deletedVorerkrankungen.Select(item => item.idKrankheitsbild).ToList()) 
                    + ");";
                connector.executeNonQuery(sql);
            }
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
