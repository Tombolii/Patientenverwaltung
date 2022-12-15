using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;

namespace Patientenverwaltung
{
    internal class DataReaderMapper
    {

        public Patient extractPatientFromReader(MySqlDataReader reader)
        {
            Patient patient = new Patient();
            while (reader.Read())
            {
                patient.idPatient = reader.GetInt32("idPatient");
                patient.versicherungsnummer = reader.GetInt32("versicherungsnummer");
                patient.versicherung = reader.GetString("name");
                extractPersonendatenFromReader(reader, patient);
            }
            return patient;
        }

        private void extractPersonendatenFromReader(MySqlDataReader reader, Patient patient)
        {
            while (reader.Read())
            {
                patient.vorname = reader.GetString("vorname");
                patient.nachname = reader.GetString("nachname");
                patient.email = reader.GetString("email");
                patient.telefonnummer = reader.GetInt32("telefonnummer");
                patient.geburtstag = DateTime.Parse(reader.GetString("geburtstag"));
                Adresse adresse = new Adresse();
                adresse.straße = reader.GetString("straße");
                adresse.hausnummer = reader.GetString("hausnummer");
                adresse.ort = reader.GetString("ort");
                adresse.plz = reader.GetInt32("plz");
                patient.adresse = adresse;
            }
        }
    }
}
