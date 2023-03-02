using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;

namespace Patientenverwaltung.Datenbank.Adapter
{
    /// <summary>
    /// Verwalten der Ärzte in der Datenbank 
    /// </summary>
    public class ArztDBAdapter: BaseDBAdapter
    {

        private AdresseDBAdapter adresseDBAdapter = new AdresseDBAdapter();
        private PersonendatenDBAdapter personendatenDBAdapter = new PersonendatenDBAdapter();

        /// <summary>
        /// Liest einen Arzt aus der Datenbank aus
        /// </summary>
        /// <param name="idArzt">des gesuchten Arztes</param>
        /// <returns>den Arzt</returns>
        public Arzt getArztById(int idArzt)
        {
            string sql = "SELECT arzt.idArzt, personendaten.vorname, personendaten.nachname, personendaten.email, personendaten.idPersonendaten, personendaten.telefonnummer, " +
                "personendaten.geburtstag, adresse.idAdresse, adresse.straße, adresse.hausnummer, adresse.ort, adresse.plz, fachgebiet.idFachgebiet, fachgebiet.bezeichnung, arzt.titel " +
                "FROM arzt " +
                "INNER JOIN personendaten ON personendaten.idPersonendaten = arzt.idPersonendaten " +
                "INNER JOIN adresse ON adresse.idAdresse = personendaten.idAdresse " +
                "INNER JOIN fachgebiet ON fachgebiet.idFachgebiet = arzt.idFachgebiet " +
                "WHERE idArzt = " + idArzt + ";";

            MySqlDataReader reader = connector.executeQuery(sql);
            return mapper.extractArztFromReader(reader);
        }
        
        /// <summary>
        /// Erstellt einen neuen Arzt in der Datenbank
        /// </summary>
        /// <param name="arzt">der neue Arzt</param>
        /// <returns>neu erstellten Arzt</returns>
        public Arzt createArzt(Arzt arzt)
        {
            arzt.adresse = adresseDBAdapter.createNewAdresse(arzt.adresse);
            Personendaten personendaten = personendatenDBAdapter.createNewPersonendaten(arzt, arzt.adresse.idAdresse);
            arzt.idPersonendaten = personendaten.idPersonendaten;

            string sql = "INSERT INTO arzt(titel, idPersonendaten, idFachgebiet, password, password_salt) VALUES('" +
                arzt.titel + "', " + arzt.idPersonendaten + ", " + arzt.idFachgebiet + ", '" + arzt.passwortInformation.password + "', '" +
                arzt.passwortInformation.passwordSalt + "'); " +
                "SELECT LAST_INSERT_ID() as 'idArzt';";
                MySqlDataReader reader = connector.executeQuery(sql);
                reader.Read();
                arzt.idArzt = reader.GetInt32("idArzt");
                reader.Close(); ;
            return arzt;
        }
    }
}
