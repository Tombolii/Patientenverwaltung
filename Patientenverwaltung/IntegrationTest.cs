using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Patientenverwaltung.Datenbank;
using Patientenverwaltung.Datenbank.Adapter;
using Patientenverwaltung.Model;

namespace Patientenverwaltung
{
    public partial class IntegrationTest : Form
    {

 
        KrankheitsbildDBAdapter krankheitsbildDBAdapter = new KrankheitsbildDBAdapter();
        PatientDBAdapter patientDBAdapter= new PatientDBAdapter();
        TerminDBAdapter terminDBAdapter= new TerminDBAdapter();
        Patient patient;
        Termin termin;
        Krankheitsbild krankheitsbild;
        Krankheitsbild krankheitsbild1;
        Krankheitsbild krankheitsbild2;

        public IntegrationTest()
        {
            InitializeComponent();
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
                idPersonendaten = 7,
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

            krankheitsbild = new Krankheitsbild()
            {
                bezeichnung = "Test-Krankheitsbild1",
                symptome = "Test-Symptome"
            };

            termin = new Termin()
            {
                idArzt =  1,
                idPatient = 1,
                zeitpunkt = DateTime.Now
            };
        }
        // Patient

        private void button2_Click(object sender, EventArgs e)
        {
  
            //myDBAdapter.addPatient(patient);
            //List<Termin> termine = myDBAdapter.getTermineOfArzt(1);    
            Console.WriteLine();
        }

        private void btnPatientErstellen_Click(object sender, EventArgs e)
        {
            Patient createdPatient = patientDBAdapter.createPatient(patient);
            Console.WriteLine(createdPatient.ToString());  
        }

        private void btnPatientBearbeiten_Click(object sender, EventArgs e)
        {
            // Testen des Synchronisierens der Vorerkrankungen mit der DB
            //patient.vorerkrankungen = new List<Krankheitsbild>(); //Entfernen von Vorerkrankungen

            patient.vorerkrankungen = new List<Krankheitsbild>() { krankheitsbild1, krankheitsbild2 }; //Hinzufügen von Vorerkrankungen
            patient.idPatient = 5;
            patientDBAdapter.modifyPatient(patient);
        }


        // Krankheitsbilder

        private void btnGetKrankheitsbilder_Click(object sender, EventArgs e)
        {
            List<Krankheitsbild> krankheitsbilder = krankheitsbildDBAdapter.getKrankheitsbilder();
            txtAusgabe.Text = krankheitsbilder.Count.ToString();
        }

        private void btnAddKrankheitsbild_Click(object sender, EventArgs e)
        {
            Krankheitsbild newKrankheitsbild = krankheitsbildDBAdapter.createKrankheitsbild(krankheitsbild);
            txtAusgabe.Text = newKrankheitsbild.idKrankheitsbild.ToString();
        }

        private void btnModifyKrankheitsbild_Click(object sender, EventArgs e)
        {
            krankheitsbild.bezeichnung = "Modified Bezeichnung";
            krankheitsbild.symptome = "Modified Symptome";
            krankheitsbild.idKrankheitsbild = 3;
            krankheitsbildDBAdapter.modifyKrankheitsbild(krankheitsbild);
        }

        private void btnDeleteKrankheitsbild_Click(object sender, EventArgs e)
        {
            krankheitsbild.idKrankheitsbild = 3;
            krankheitsbildDBAdapter.deleteKrankheitsbild(krankheitsbild.idKrankheitsbild);
        }

        private void btnAddTermin_Click(object sender, EventArgs e)
        {
            Termin newTermin = terminDBAdapter.addTermin(termin);
            txtAusgabe.Text = newTermin.idTermin.ToString();
        }
    }
}
