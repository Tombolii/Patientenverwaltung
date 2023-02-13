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

        public void ärzteseiteSearchPat()
        {
            //Fertig - Ungetestet
            programmstart.Hide();
            patient.Show();
        }

        public void ärzteseiteAddTermin()
        {
            //Fertig - Ungestestet
            programmstart.Hide();
            neuerTermin.Show();
        }

        public void berichtBackToPat()
        {
            //Fertig - Ungestestet
            bericht.Hide();
            patient.Show();
        }

        public void berichtSearchBericht()
        {
            //Fertig - Ungestestet
            bericht.Hide();
            berichtDaten.Show();
            
        }

        public void berichtAddBericht()
        {
            //Fertig - Ungestestet
            bericht.Hide();
            neuerBericht.Show();
        }

        public void berichtBearbeitenSaveChange()
        {
            //Fertig - Ungestestet
            berichtBearbeiten.Hide();
            bericht.Show();
        }

        public void berichtBearbeitenClose()
        {
            //Fertig - Ungestestet
            berichtBearbeiten.Hide();
            bericht.Show();
        }

        public void berichtDatenChange()
        {
            //Fertig - Ungestestet
            berichtDaten.Hide();
            berichtBearbeiten.Show();
        }

        public void berichtDatenBack()
        {
            //Fertig - Ungestestet
            berichtDaten.Hide();
            bericht.Show();
        }

        public void neuerBerichtAddBericht()
        {
            //Fertig - Ungestestet
            neuerBericht.Hide();
            bericht.Show();
        }

        public void neuerBerichtClose()
        {
            //Fertig - Ungestestet
            neuerBericht.Hide();
            bericht.Show();
        }

        public void neuerPatientAddPat()
        {
            //Fertig - Ungestestet
            neuerPatient.Hide();
            patient.Show();
        }

        public void neuerPatientClose()
        {
            //Fertig - Ungestestet
            neuerPatient.Hide();
            patient.Show();
        }

        public void neuerTerminAddTermin()
        {
            //Fertig - Ungestestet
            neuerTermin.Hide();
            programmstart.Show();
        }

        public void neuerTerminClose()
        {
            //Fertig - Ungestestet
            neuerTermin.Hide();
            programmstart.Show();
        }

        public void patientBearbeitenSaveChange()
        {
            //Fertig - Ungestestet
            patientBearbeiten.Hide();
            patient.Show();
        }

        public void patientBearbeitenClose()
        {
            //Fertig - Ungestestet
            patientBearbeiten.Hide();
            patient.Show();
        }

        public void patientenBackToStart()
        {
            //Fertig - Ungestestet
            patient.Hide();
            programmstart.Show();
        }

        public void patientSearchPat()
        {
            //Fertig - Ungestestet
            patient.Hide();
            patientenDaten.Show();
        }

        public void patientAddPat()
        {
            //Fertig - Ungestestet
            patient.Hide();
            neuerPatient.Show();
        }

        public void patientDatenChangePat()
        {
            //Fertig - Ungestestet
            patientenDaten.Hide();
            patientBearbeiten.Show();
        }

        public void patientDatenOpenBerichte()
        {
            //Fertig - Ungestestet
            patientenDaten.Hide();
            berichtDaten.Show();
        }

        public void patientDatenBack()
        {
            //Fertig - Ungestestet
            patientenDaten.Hide();
            patient.Show();
        }

        public void terminBearbeitenSaveChange()
        {
            //Fertig - Ungestestet
            terminBearbeiten.Hide();
            programmstart.Show();
        }

        public void terminBearbeitenClose()
        {
            //Fertig - Ungestestet
            terminBearbeiten.Hide();
            programmstart.Show();
        }

        public void terminDatenChangeTermin()
        {
            //Fertig - Ungestestet
            terminDaten.Hide();
            terminBearbeiten.Show();
        }

        public void terminDatenDeleteTermin()
        {
            //Fertig - Ungestestet
            terminDaten.Hide();
            programmstart.Show();
        }

        public void terminDatenClose()
        {
            //Fertig - Ungestestet
            terminDaten.Hide();
            programmstart.Show();
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
