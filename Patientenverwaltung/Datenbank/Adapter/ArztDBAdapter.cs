﻿using MySql.Data.MySqlClient;
using Patientenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Datenbank.Adapter
{
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
        
        public Arzt createNewArzt(Arzt arzt)
        {
            string sql = "INSERT INTO arzt(titel, idPersonendaten, idFachgebiet, password) VALUES('" +
                arzt.titel + "', " + arzt.idPersonendaten + ", " + arzt.idFachgebiet + ", '" + arzt.passwort + "'); " +
                "SELECT LAST_INSERT_ID() as 'idArzt';";
                MySqlDataReader reader = connector.executeQuery(sql);
                reader.Read();
                arzt.idArzt= reader.GetInt32("idArzt");
                reader.Close(); ;

            return arzt;
        }

    }
}
