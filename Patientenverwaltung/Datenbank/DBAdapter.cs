﻿using System;
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



        MySQLConnector connector = new MySQLConnector(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);

        public List<Termin> getTermineOfArzt(int idArzt)
        {
            string condition = "WHERE idArzt = " + idArzt;

            string sql = "SELECT termin.zeitpunkt, termin.idPatient, termin.idArzt " +
                "FROM termin ";
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
                
            }
        }

        public void getPatientById(int idPatient)
        {
            string sql = "SELECT patient.idPatient, personendaten.vorname, personendaten.nachname, personendaten.email, personendaten.telefonnummer, " +
                "personendaten.geburtstag, adresse.straße, adresse.hausnummer, adresse.ort, adresse.plz, versicherung.name, patient.versicherungsnummer, " +
                "FROM patient " +
                "INNER JOIN personendaten ON personendaten.idPersonendaten = patient.idPersonendaten " +
                "INNER JOIN adresse ON adresse.idAdresse = personendaten.idAdresse " +
                "INNER JOIN versicherung ON versicherung.idVersicherung = patient.idVersicherung " +
                "WHERE idPatient = " + idPatient + ";";
            
            MySqlDataReader reader = connector.executeQuery(sql);

        }

        public void insertTaetigkeitenMigration(TaetigkeitenModel model)
        {
            foreach (var item in model.Taetigkeiten)
            {
                string sql = "INSERT INTO tbltaetigkeit (taetID, bezeichnung, verrechnungspreis) VALUES("
                        + item.ID + ", '"
                        + item.Bezeichnung + "', "
                        + item.Verrechnungspreis + ");";

                connector.executeNonQuery(sql);
            }

        }


        public void insertPersonalMigration(PersonalModel personal)
        {
            string sql = "SELECT abtID FROM tblAbteilung WHERE abteilung = '" + personal.abteilung + "';";
            sql = "INSERT INTO tblPersonal (persID, name, vorname, geschlecht, gebdatum, straße, telNr, eintrittsdatum, grundgehalt, abtID, ortsID) " +
                        "VALUES('" + personal.personalID + "', '"
                        + personal.name + "', '"
                        + personal.vorname + "', '"
                        + personal.geschlecht + "', '"
                        + personal.gebdatum.ToString("yyyy/M/dd").Replace(".", "-") + "', '"
                        + personal.straße + "', '"
                        + personal.telNr + "', '"
                        + personal.eintrittsdatum.ToString("yyyy/M/dd").Replace(".", "-") + "', '"
                        + personal.grundgehalt + "', ("
                        + "SELECT abtID FROM tblAbteilung WHERE abteilung = '" + personal.abteilung + "'), '"
                        + personal.ortsID + "');";

            connector.executeNonQuery(sql);
        }

        public void insertAbteilungMigration(AbteilungModel abteilung)
        {

            string sql = "INSERT INTO tblAbteilung (abteilung, nameAbtLeiter, vornameAbtLeiter) "
                        + "VALUES('" + abteilung.abteilung + "', '"
                        + abteilung.nameAbtLeiter + "', '"
                        + abteilung.vornameAbtLeiter + "');";

            connector.executeNonQuery(sql);
        }

        public void insertAuftragMigration(AuftragModel auftrag)
        {
            string sql = "INSERT INTO tblAuftrag (auftragsID, wert, abrechgdatum, kundenID, persID) VALUES("
                        + auftrag.ID + ", "
                        + auftrag.Wert + ", '"
                        + auftrag.Abrechgdatum.ToString("yyyy/M/dd").Replace(".", "-") + "', "
                        + "(SELECT kundenID FROM tblKunde WHERE uName = '" + auftrag.kundenName + "'), "
                        + "(SELECT persID FROM tblBericht WHERE auftrID = " + auftrag.ID + "));";

            connector.executeNonQuery(sql);
        }

        public void insertBerichtMigration(BerichtModel bericht)
        {
            string sql = "INSERT INTO tblBericht (persID, datum, auftrID, taetID, std) VALUES("
                        + bericht.PersID + ", '"
                        + bericht.Datum.ToString("yyyy/M/dd").Replace(".", "-") + "', "
                        + bericht.AuftrID + ", "
                        + bericht.TaetID + ", "
                        + bericht.stunden + ");";

            connector.executeNonQuery(sql);
        }


        public void insertKundeMigration(KundeModel kunde)
        {
            string sql = "INSERT INTO tblKunde (uName) VALUES ('" + kunde.kundenName + "');";
            connector.executeNonQuery(sql);
        }


        public void insertVerwandtschaftMigration(VerwandtschaftModel verwandtschaft)
        {

            string sql = "INSERT INTO tblverwandtschaft (persID, verwandtschaftsgrad, bezeichnung, zuschuss, vorname) VALUES("
                        + verwandtschaft.persID + ", '"
                        + verwandtschaft.verwandtschaftsgrad + "', '"
                        + verwandtschaft.bezeichung + "', '"
                        + verwandtschaft.zuschuss + "', '"
                        + verwandtschaft.vorname + "');";

            connector.executeNonQuery(sql);
        }





    }
}
