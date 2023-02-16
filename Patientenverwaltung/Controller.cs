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
        private List<Termin> termine;
        private Login login = null;

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
            termine = new List<Termin>();
            login = new Login(this);
    }

        public DBAdapter dBAdapter = new DBAdapter();
        public Form startProgram()
        {
            return login;
        }

        public void programmStart()
        {
            programmstart.displayAllTermine();
            login.Hide();
            programmstart.Show();
        }

        public void ärzteseiteSearchPat()
        {
            programmstart.Hide();
            patient.Show();
        }

        public void ärzteseiteAddTermin()
        {
            programmstart.Hide();
            neuerTermin.Show();
        }

        public void berichtBackToPat()
        {
            bericht.Hide();
            patient.Show();
        }

        public void berichtSearchBericht()
        {
            bericht.Hide();
            berichtDaten.Show();
            
        }

        public void berichtAddBericht()
        {
            bericht.Hide();
            neuerBericht.Show();
        }

        public void berichtBearbeitenSaveChange()
        {
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

        public void neuerPatientAddPat(Patient patienten)
        {
            neuerPatient.Hide();
            patient.Show();
            /*
            DBAdapter dBAdapter = new DBAdapter();
            Patient createdPatient = dBAdapter.addPatient(patienten);
            patienten.Add(createdPatient);
            neuerPatient.Hide();
            patient.Show();

            patient.addPatientToFrontend(createdPatient)
            */
        }

        public void neuerPatientClose()
        {
            //Fertig - Ungestestet
            neuerPatient.Hide();
            patient.Show();
        }

        public void neuerTerminAddTermin(Termin termin)
        {
            DBAdapter dBAdapter = new DBAdapter();
            Termin createdTermin = dBAdapter.addTermin(termin);
            termine.Add(createdTermin);
            neuerTermin.Hide();
            programmstart.Show();

            programmstart.addTerminToFrontend(createdTermin);
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

        public List<Termin> GetTermineOfArzt(int idArzt)
        {
            return adapter.getTermineOfArzt(idArzt);               
        }
        public List<Termin> getTermineOfPatient(int idPatient)
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
