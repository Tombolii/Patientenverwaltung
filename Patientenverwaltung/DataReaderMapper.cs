using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;

namespace Patientenverwaltung
{
    public class DataReaderMapper
    {

        public List<Patient> extractPatientenFromReader(MySqlDataReader reader)
        {   
            List<Patient> patienten = new List<Patient>();
            while (reader.Read())
            {
                Patient patient = new Patient();
                patient.idPatient = reader.GetInt32("idPatient");
                patient.versicherungsnummer = reader.GetInt32("versicherungsnummer");
                Versicherung versicherung = new Versicherung()
                {
                    name = reader.GetString("name"),
                    idVersicherung = reader.GetInt32("idVersicherung")
                };
                extractPersonendatenFromReader(reader, patient);
                patienten.Add(patient);
            }
            reader.Close();
            return patienten;
        }

        public Arzt extractArztFromReader(MySqlDataReader reader)
        {
            Arzt arzt = new Arzt();
            while (reader.Read())
            {
                arzt.idArzt = reader.GetInt32("idArzt");
                arzt.fachgebiet = reader.GetString("fachgebiet");
                arzt.titel = reader.GetString("titel");
                extractPersonendatenFromReader(reader, arzt);
            }
            reader.Close();
            return arzt;
        }

        private void extractPersonendatenFromReader(MySqlDataReader reader, Personendaten person)
        {
                person.vorname = reader.GetString("vorname");
                person.nachname = reader.GetString("nachname");
                person.email = reader.GetString("email");
                person.telefonnummer = reader.GetString("telefonnummer");
                person.geburtstag = DateTime.Parse(reader.GetString("geburtstag"));
            Adresse adresse = new Adresse
            {
                    idAdresse = reader.GetInt32("idAdresse"),
                    straße = reader.GetString("straße"),
                    hausnummer = reader.GetString("hausnummer"),
                    ort = reader.GetString("ort"),
                    plz = reader.GetInt32("plz")
                };
                person.adresse = adresse;
        }
    }
}
