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
    
    public class Controller
    {
        private Programmstart programmstart = null;
        private Bericht bericht = null;
        private BerichtBearbeiten berichtBearbeiten = null;
        private BerichtDaten_cs berichtDaten = null;
        private NeuerBericht neuerBericht = null;
        private NeuerPatient neuerPatient = null;
        private NeuerTermin neuerTermin = null;
        private PatientBearbeiten patientBearbeiten = null;
        private Patienten patient = null;
        private PatientenDaten patientenDaten = null;
        private TerminBearbeiten terminBearbeiten = null;
        private TerminDaten terminDaten = null;
        private DBAdapter adapter = new DBAdapter();

        public Controller()
        {
            programmstart = new Programmstart(this);
          bericht = new Bericht(this);
          berichtBearbeiten = new BerichtBearbeiten(this);
          berichtDaten = new BerichtDaten_cs(this);
          neuerBericht = new NeuerBericht(this);
          neuerPatient = new NeuerPatient(this);
          neuerTermin = new NeuerTermin(this);
          patientBearbeiten = new PatientBearbeiten(this);
          patient = new Patienten(this);
          patientenDaten = new PatientenDaten(this);
          terminBearbeiten = new TerminBearbeiten(this);
          terminDaten = new TerminDaten(this);

    }

    public Form startProgram()
        { return programmstart; }

        public  void saveTermin()
        {
            neuerTermin.Hide();
            programmstart.Show();
        }
        public  void addTermin()
        {
            programmstart.Hide();
            neuerTermin.ShowDialog();
        }

        public void modifyTermin()
        {
            programmstart.Hide();
            berichtDaten.Show();
        }

        public  void showTermin()
        {
            programmstart.Hide();
            terminDaten.Show();
        }

        public  void closeTermin()
        {
            terminDaten.Hide();
            programmstart.Show();
        }

        public  void getBericht()
        {   
            programmstart.Hide();
            bericht.Show(); 
        }

        public  void modifyBericht()
        { 
            programmstart.Hide();
            berichtBearbeiten.Show(); 
        }

        public  void showBericht()
        {
            programmstart.Hide();
            berichtDaten.Show();
        }

        public  void addBericht()
        {
            programmstart.Hide();
            neuerBericht.Show();
        }

        public  void addPatient()
        {
            programmstart.Hide();
            neuerPatient.Show();
        }

        public  void modifyPatient()
        {
            programmstart.Hide();
            berichtBearbeiten.Show();
        }

        public  void Patient()
        {
            programmstart.Hide();
            patient.Show();
        }

        public  void closePatient()
        {
            patient.Hide();
            programmstart.Show();
        }

        public  void showPatienten()
        {
            programmstart.Hide();
            patientenDaten.Show();
        }

        public List<Termin> GetTerminArzt(int idArzt)
        {

            

            Patient patient= new Patient();
            patient.idPatient = 1;
            patient.nachname = "Müller";
            patient.vorname = "Mascarpone";
            Termin termin = new Termin();
            termin.idTermin = 1;
            DateTime dt = DateTime.Now;
            termin.zeitpunkt = dt;
            termin.patient =patient;
            //return adapter.getTermineOfArzt(idArzt);            
            List<Termin> testlist = new List<Termin>();
            testlist.Add(termin);
            return testlist;

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
