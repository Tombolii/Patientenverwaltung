using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Patientenverwaltung.Datenbank;
using Patientenverwaltung.Model;

namespace Patientenverwaltung
{
    public partial class IntegrationTest : Form
    {

        MySQLConnector mySqlConnector;
        DBAdapter myDBAdapter = new DBAdapter();
        Patient patient;
        Krankheitsbild krankheitsbild1;
        Krankheitsbild krankheitsbild2;

        public IntegrationTest()
        {
            InitializeComponent();
            mySqlConnector = new MySQLConnector("patientenverwaltung");
            mySqlConnector.DBUser = "Arzt";
            mySqlConnector.DBPassword = "";
            mySqlConnector.DBHost = "";

            Adresse adresse = new Adresse()
            {
                idAdresse = 13,
                straße = "Teststraße",
                hausnummer = "33",
                ort = "Stuttgart",
                plz = 12345
            };

            krankheitsbild1 = new Krankheitsbild()
            {
                idKrankheitsbild = 1,
                bezeichnung = "Corona",
                symptome = "Husten, Atemprobleme, Uebelkeit, Schwindel"
            };

            krankheitsbild2 = new Krankheitsbild()
            {
                idKrankheitsbild = 2,
                bezeichnung = "Grippe",
                symptome = "Fieber, Husten, Schnupfen"
            };

            List<Krankheitsbild> vorerkrankungen = new List<Krankheitsbild>()
            {
                krankheitsbild1
            };
            Versicherung versicherung = new Versicherung()
            {
                idVersicherung = 1,
                name = "Techniker Krankenkasse"
            };
            patient = new Patient()
            {
                idPersonendaten= 7,
                vorname = "Samuel2",
                nachname = "Jaschke2",
                email = "test2.test@gmail.com",
                geburtstag = DateTime.Now,
                adresse = adresse,
                telefonnummer = "12345622222227",
                versicherungsnummer = 1234222225,
                vorerkrankungen = vorerkrankungen,
                versicherung = versicherung
            };
        }


        private void button2_Click(object sender, EventArgs e)
        {
  
            //myDBAdapter.addPatient(patient);
            //List<Termin> termine = myDBAdapter.getTermineOfArzt(1);    
            Console.WriteLine();
        }

        private void btnPatientErstellen_Click(object sender, EventArgs e)
        {
            Patient createdPatient = myDBAdapter.addPatient(patient);
            Console.WriteLine(createdPatient.ToString());  
        }

        private void btnPatientBearbeiten_Click(object sender, EventArgs e)
        {
            // Testen des Synchronisierens der Vorerkrankungen mit der DB
            //patient.vorerkrankungen = new List<Krankheitsbild>(); //Entfernen von Vorerkrankungen

            patient.vorerkrankungen = new List<Krankheitsbild>() { krankheitsbild1, krankheitsbild2 }; //Hinzufügen von Vorerkrankungen
            patient.idPatient = 5;
            myDBAdapter.modifyPatient(patient);
        }
    }
}
