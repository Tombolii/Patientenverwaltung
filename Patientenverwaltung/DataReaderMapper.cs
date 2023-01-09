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
            return arzt;
        }

        private void extractPersonendatenFromReader(MySqlDataReader reader, Personendaten person)
        {
            while (reader.Read())
            {
                person.vorname = reader.GetString("vorname");
                person.nachname = reader.GetString("nachname");
                person.email = reader.GetString("email");
                person.telefonnummer = reader.GetString("telefonnummer");
                person.geburtstag = DateTime.Parse(reader.GetString("geburtstag"));
                Adresse adresse = new Adresse
                {
                    straße = reader.GetString("straße"),
                    hausnummer = reader.GetString("hausnummer"),
                    ort = reader.GetString("ort"),
                    plz = reader.GetInt32("plz")
                };
                person.adresse = adresse;
            }
        }
    }
}
