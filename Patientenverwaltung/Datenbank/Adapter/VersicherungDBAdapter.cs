using System.Collections.Generic;
using Patientenverwaltung.Model;
using MySql.Data.MySqlClient;


namespace Patientenverwaltung.Datenbank.Adapter
{
    public class VersicherungDBAdapter: BaseDBAdapter
    {

        /// <summary>
        /// Liest alle Versicherungen aus der Datenbank aus
        /// </summary>
        /// <returns>Liste aller Versicherungen</returns>
        public List<Versicherung> getAllVersicherungen()
        {
            List<Versicherung> versicherungen = new List<Versicherung>();
            string sql = "SELECT idVersicherung, name FROM versicherung;";

            MySqlDataReader reader = connector.executeQuery(sql);
            while (reader.Read())
            {
                Versicherung versicherung = new Versicherung
                {
                    idVersicherung = reader.GetInt32("idVersicherung"),
                    name = reader.GetString("name")
                };
                versicherungen.Add(versicherung);
            }
            reader.Close();
            return versicherungen;
        }
    }
}
