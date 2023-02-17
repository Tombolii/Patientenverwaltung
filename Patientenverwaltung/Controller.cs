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
using BerichtForm = Patientenverwaltung.Gui.BerichtForm;
using Patientenverwaltung.Datenbank.Adapter;

namespace Patientenverwaltung
{
    
    public class Controller
    {
        // GUI-Forms
        private ArztOverviewForm programmstart = null;
        private BerichtForm bericht = null;
        private BerichtBearbeitenForm berichtBearbeiten = null;
        private BerichtDaten_cs berichtDaten = null;
        private NeuerBerichtForm neuerBericht = null;
        private NeuerPatientForm neuerPatient = null;
        private NeuerTerminForm neuerTermin = null;
        private PatientBearbeitenForm patientBearbeiten = null;
        private PatientSucheForm patient = null;
        private PatientenDatenForm patientenDaten = null;
        private TerminBearbeitenForm terminBearbeiten = null;
        private TerminDatenForm terminDaten = null;
        private Login login = null;

        // Adapter
        private TerminDBAdapter terminDBAdapter;
        private ArztDBAdapter arztDBAdapter;
        private BerichtDBAdapter berichtDBAdapter;
        private PatientDBAdapter patientDBAdapter;


        private List<Termin> termine;
        

        public Controller()
        {
            // GUI-Forms
            programmstart = new ArztOverviewForm(this);
            bericht = new BerichtForm(this);
            berichtBearbeiten = new BerichtBearbeitenForm(this);
            berichtDaten = new BerichtDaten_cs(this);
            neuerBericht = new NeuerBerichtForm(this);
            neuerPatient = new NeuerPatientForm(this);
            neuerTermin = new NeuerTerminForm(this);
            patientBearbeiten = new PatientBearbeitenForm(this);
            patient = new PatientSucheForm(this);
            patientenDaten = new PatientenDatenForm(this);
            terminBearbeiten = new TerminBearbeitenForm(this);
            terminDaten = new TerminDatenForm(this);
            login = new Login(this);

            // Adapter
            terminDBAdapter = new TerminDBAdapter();
            arztDBAdapter = new ArztDBAdapter();
            berichtDBAdapter= new BerichtDBAdapter();
            patientDBAdapter= new PatientDBAdapter();

            termine = new List<Termin>();
            
    }

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
            Termin createdTermin = terminDBAdapter.addTermin(termin);
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
            return terminDBAdapter.getTermineOfArzt(idArzt);               
        }
        public List<Termin> getTermineOfPatient(int idPatient)
        {
            return terminDBAdapter.getTermineOfPatient(idPatient);
        }
        public List<BerichtForm> getBericht(int idPatient)
        {
            return null;
        }

        public List<Krankheitsbild> getKrankheiten(int idPatient)
        {
            return null;
        }

    }
}
