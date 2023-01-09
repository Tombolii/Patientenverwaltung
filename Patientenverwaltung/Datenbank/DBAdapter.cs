using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;

namespace Patientenverwaltung.Datenbank
{
    internal class DBAdapter
    {

        public static string DB_NAME = "patientenverwaltung";
        public static string DB_PASSWORD = "";
        public static string DB_USER = "Arzt";
        public static string DB_HOST = "10.1.13.119";

        DataReaderMapper mapper = new DataReaderMapper();

        MySQLConnector connector = new MySQLConnector(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);

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

        public Patient getPatientById(int idPatient)
        {
            string sql = "SELECT patient.idPatient, personendaten.vorname, personendaten.nachname, personendaten.email, personendaten.telefonnummer, " +
                "personendaten.geburtstag, adresse.straße, adresse.hausnummer, adresse.ort, adresse.plz, versicherung.name, patient.versicherungsnummer, " +
                "FROM patient " +
                "INNER JOIN personendaten ON personendaten.idPersonendaten = patient.idPersonendaten " +
                "INNER JOIN adresse ON adresse.idAdresse = personendaten.idAdresse " +
                "INNER JOIN versicherung ON versicherung.idVersicherung = patient.idVersicherung " +
                "WHERE idPatient = " + idPatient + ";";
            
            MySqlDataReader reader = connector.executeQuery(sql);
            return mapper.extractPatientFromReader(reader);
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

        public void deletePatient(int idPatient)
        {
            string sql = "DELETE FROM patient WHERE idPatient = " + idPatient + ";";
            connector.executeNonQuery(sql);
        }

        public void modifyPatient(Patient patient)
        {
            string sql = "UPDATE patient " +
                "SET patient.versicherungsnummer = " + patient.versicherungsnummer + ", "
                + "personendaten.vorname = " + patient.vorname + ", "
                + "personendaten.nachname = " + patient.nachname + ", "
                + "personendaten.email = " + patient.email + ", "
                + "personendaten.telefonnummer = " + patient.telefonnummer + ", "
                + "personendaten.geburtstag = " + patient.geburtstag + ", "
                + "adresse.straße = " + patient.adresse.straße + ", "
                + "adresse.hausnummer = " + patient.adresse.hausnummer + ", "
                + "adresse.ort = " + patient.adresse.ort + ", "
                + "adresse.plz = " + patient.adresse.plz
                + "FROM patient " +
                "INNER JOIN personendaten ON personendaten.idPersonendaten = patient.idPatient " +
                "INNER JOIN adresse ON adresse.idAdresse = personendaten.idAdresse;";
           
            connector.executeNonQuery(sql);
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
                termin.patient = getPatientById(reader.GetInt32("idPatient"));
                termin.arzt = getArztById(reader.GetInt32("idArzt"));
                termine.Add(termin);
            }
            reader.Close();
            return termine;
        }
    }
}
