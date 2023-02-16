using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;
using System.Collections.Generic;


namespace Patientenverwaltung.Datenbank.Adapter
{
    public class PatientDBAdapter : BaseDBAdapter
    {

        private AdresseDBAdapter adresseDBAdapter = new AdresseDBAdapter();
        private PersonendatenDBAdapter personendatenDBAdapter= new PersonendatenDBAdapter();
        private VorerkrankungDBAdapter vorerkrankungDBAdapter = new VorerkrankungDBAdapter();

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

        /// <summary>
        /// Löscht einen bestimmten Patienten aus der Datenbank
        /// </summary>
        /// <param name="idPatient">des zu löschenden Patienten</param>
        public void deletePatient(int idPatient)
        {
            string sql = "DELETE FROM patient WHERE idPatient = " + idPatient + ";";
            connector.executeNonQuery(sql);
        }

        /// <summary>
        /// Aktualisiert einen Patienten in der Datenbank
        /// </summary>
        /// <param name="patient">aktualiserte Patient</param>
        /// <returns>den aktualisierten Patienten</returns>
        public Patient modifyPatient(Patient patient)
        {
            // Update adresse
            adresseDBAdapter.updateAdresse(patient.adresse);

            // Update personendaten
            personendatenDBAdapter.updatePersonendaten(patient);

            // Update patient
            updatePatient(patient);
      
            // Vorerkrankungen synchronisieren
            List<Krankheitsbild> currentVorerkrankungen = vorerkrankungDBAdapter.getVorerkrankungenOfPatient(patient.idPatient);
            if (!patient.vorerkrankungen.Equals(currentVorerkrankungen))
            {
                vorerkrankungDBAdapter.synchVorerkrankungenOfPatient(patient.idPatient, patient.vorerkrankungen, currentVorerkrankungen);
            }
            return patient;
        }

        /// <summary>
        /// Fügt einen neuen Patienten in die Datenbank ein
        /// </summary>
        /// <param name="newPatient">neuer Patient</param>
        /// <returns>den neu erstellten Patienten</returns>
        public Patient createPatient(Patient newPatient)
        {
            // Anlegen der Adresse
            adresseDBAdapter.createNewAdresse(newPatient.adresse);

            // Anlegen der Personendaten
            personendatenDBAdapter.createNewPersonendaten(newPatient);

            // Anlegen des Patienten und Auslesen der Id des neuen Patienten
            addPatient(newPatient);

            // Vorerkrankungen synchronisieren
            vorerkrankungDBAdapter.synchVorerkrankungenOfPatient(
                newPatient.idPatient, newPatient.vorerkrankungen, new List<Krankheitsbild>());
            return newPatient;
        }

        private void addPatient(Patient patient)
        {
            string sql = "INSERT INTO patient (idVersicherung, idPersonendaten, versicherungsnummer) " +
            "VALUES(" + patient.versicherung.idVersicherung + ", " +
            "LAST_INSERT_ID(), " +
            patient.versicherungsnummer + "); " +
            "SELECT LAST_INSERT_ID() as 'idPatient'";
            MySqlDataReader reader = connector.executeQuery(sql);
            reader.Read();
            patient.idPatient = reader.GetInt32("idPatient");
            reader.Close();
        }

        private void updatePatient(Patient patient)
        {
            string sql = "UPDATE patient " +
            "SET versicherungsnummer = " + patient.versicherungsnummer + ", " +
            "idVersicherung = " + patient.versicherung.idVersicherung + " " +
            "WHERE idPatient = " + patient.idPatient + ";";

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
    }
}
