using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patientenverwaltung;
using Patientenverwaltung.Model;
using Patientenverwaltung.Datenbank;
using Patientenverwaltung.Gui;
using Bericht = Patientenverwaltung.Gui.Bericht;

namespace Patientenverwaltung
{
    
    class Controller
    {
        static Programmstart programmstart = new Programmstart();
        static Bericht bericht = new Bericht();
        static BerichtBearbeiten berichtBearbeiten = new BerichtBearbeiten();
        static BerichtDaten_cs berichtDaten = new BerichtDaten_cs();
        static NeuerBericht neuerBericht = new NeuerBericht();
        static NeuerPatient neuerPatient = new NeuerPatient();
        static NeuerTermin neuerTermin = new NeuerTermin();
        static PatientBearbeiten patientBearbeiten = new PatientBearbeiten();
        static Patienten patient = new Patienten();
        static PatientenDaten patientenDaten = new PatientenDaten();
        static TerminBearbeiten terminBearbeiten = new TerminBearbeiten ();
        static TerminDaten terminDaten = new TerminDaten ();
        static DBAdapter adapter = new DBAdapter();

        public static Form startProgram()
        { return programmstart; }

        public static void saveTermin()
        {
            neuerTermin.Hide();
            programmstart.Show();
        }
        public static void addTermin()
        {
            programmstart.Hide();
            neuerTermin.ShowDialog();
        }

        public static void modifyTermin()
        {
            programmstart.Hide();
            berichtDaten.Show();
        }

        public static void showTermin()
        {
            programmstart.Hide();
            terminDaten.Show();
        }

        public static void closeTermin()
        {
            terminDaten.Hide();
            programmstart.Show();
        }

        public static void getBericht()
        {   
            programmstart.Hide();
            bericht.Show(); 
        }

        public static void modifyBericht()
        { 
            programmstart.Hide();
            berichtBearbeiten.Show(); 
        }

        public static void showBericht()
        {
            programmstart.Hide();
            berichtDaten.Show();
        }

        public static void addBericht()
        {
            programmstart.Hide();
            neuerBericht.Show();
        }

        public static void addPatient()
        {
            programmstart.Hide();
            neuerPatient.Show();
        }

        public static void modifyPatient()
        {
            programmstart.Hide();
            berichtBearbeiten.Show();
        }

        public static void Patient()
        {
            programmstart.Hide();
            patient.Show();
        }

        public static void closePatient()
        {
            patient.Hide();
            programmstart.Show();
        }

        public static void showPatienten()
        {
            programmstart.Hide();
            patientenDaten.Show();
        }

        public List<Termin> getTerminArzt(int idArzt)
        {
            return adapter.getTermineOfArzt(idArzt);            

        }
        public List<Termin> getTerminPatient(int idPatient)
        {
            return adapter.getTermineOfPatient(idPatient);
        }

        public List<Bericht> getBericht(int idPatient)
        {
            return null;
        }

        public List<Krankheitsbild> getKrankheiten(int idPatient)
        {
            return null;
        }
        

    }
}
