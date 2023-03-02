namespace Patientenverwaltung.Datenbank
{
    public abstract class BaseDBAdapter
    {

        protected DataReaderMapper mapper = new DataReaderMapper();
        protected MySQLConnector connector = new MySQLConnector(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);

        private const string DB_NAME = "patientenverwaltung";
        private const string DB_PASSWORD = "";
        private const string DB_USER = "Arzt";
        private const string DB_HOST = "localhost";
    }
}
