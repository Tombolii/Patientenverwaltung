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

        public Patient getPatient(int idPatient)
        {
            string condition = "WHERE idPatient = " + idPatient + ";";
            return getPatientByCondition(condition);
        }
        
        public Patient getPatient(string nachname)
        {
            string condition = "WHERE nachname = '" + nachname + "';";
            return getPatientByCondition(condition);
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
            string sql = "DELET FROM patient WHERE idPatient = " + idPatient + ";";
            connector.executeNonQuery(sql);
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

        public void modifyBericht(Bericht modifiedBericht)
        {
            string sql = "UPDATE bericht " +
                "SET beschwerden = " + modifiedBericht.beschwerden + ", " +
                "bemerkung = " + modifiedBericht.bemerkung + ", " +
                "diagnose = " + modifiedBericht.diagnose.idKrankheitsbild + " " +
                "WHERE idBericht = " + modifiedBericht.idBericht + ";";

            connector.executeNonQuery(sql);
        }

        public void addBericht(Bericht newBericht)
        {
            string sql = "INSERT INTO bericht (idPatient, beschwerden, bemerkung, diagnose) " +
                "VALUES(" + newBericht.patient.idPatient + ", " +
                newBericht.beschwerden + ", " +
                newBericht.bemerkung + ", " +
                newBericht.diagnose.idKrankheitsbild + ";";

            connector.executeNonQuery(sql);
        }

        public void deleteBericht(Bericht bericht)
        {
            string sql = "DELETE FROM bericht WHERE idBericht = " + bericht.idBericht + ";";

            connector.executeNonQuery(sql);
        }

        private Patient getPatientByCondition(string condition)
        {
            string sql = "SELECT patient.idPatient, personendaten.vorname, personendaten.nachname, personendaten.email, personendaten.telefonnummer, " +
                "personendaten.geburtstag, adresse.straße, adresse.hausnummer, adresse.ort, adresse.plz, versicherung.name, patient.versicherungsnummer, " +
                "FROM patient " +
                "INNER JOIN personendaten ON personendaten.idPersonendaten = patient.idPersonendaten " +
                "INNER JOIN adresse ON adresse.idAdresse = personendaten.idAdresse " +
                "INNER JOIN versicherung ON versicherung.idVersicherung = patient.idVersicherung " +
                condition + ";";

            MySqlDataReader reader = connector.executeQuery(sql);
            return mapper.extractPatientFromReader(reader);
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
    }
}
