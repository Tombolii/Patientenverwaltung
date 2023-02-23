using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patientenverwaltung.Model;
using Patientenverwaltung.Gui;
using Patientenverwaltung.Datenbank.Adapter;

namespace Patientenverwaltung
{
    
    public class Controller
    {
        // GUI-Forms
        private ArztOverviewForm arztOverview = null;
        private BerichtForm berichtForm = null;
        private BerichtBearbeitenForm berichtBearbeitenForm = null;
        private BerichtDatenForm berichtDatenForm = null;
        private NeuerBerichtForm neuerBerichtForm = null;
        private NeuerPatientForm neuerPatientForm = null;
        private NeuerTerminForm neuerTerminForm = null;
        private PatientBearbeitenForm patientBearbeitenForm = null;
        private PatientOverviewForm patientOverviewForm = null;
        private PatientenDatenForm patientenDatenForm = null;
        private TerminBearbeitenForm terminBearbeitenForm = null;
        private TerminDatenForm terminDatenForm = null;
        private LoginForm loginForm = null;

        // Adapter
        private TerminDBAdapter terminDBAdapter;
        private ArztDBAdapter arztDBAdapter;
        private BerichtDBAdapter berichtDBAdapter;
        private PatientDBAdapter patientDBAdapter;

        private Arzt loggedInArzt;
        private Patient currentSelectedPatient;
        private List<Termin> termine;
        private List<Patient> patienten;
        

        public Controller()
        {
            // GUI-Forms
            arztOverview = new ArztOverviewForm(this);
            berichtForm = new BerichtForm(this);
            berichtBearbeitenForm = new BerichtBearbeitenForm(this);
            berichtDatenForm = new BerichtDatenForm(this);
            neuerBerichtForm = new NeuerBerichtForm(this);
            neuerPatientForm = new NeuerPatientForm(this);
            neuerTerminForm = new NeuerTerminForm(this);
            patientBearbeitenForm = new PatientBearbeitenForm(this);
            patientOverviewForm = new PatientOverviewForm(this);
            patientenDatenForm = new PatientenDatenForm(this);
            terminBearbeitenForm = new TerminBearbeitenForm(this);
            terminDatenForm = new TerminDatenForm(this);
            loginForm = new LoginForm(this);

            // Adapter
            terminDBAdapter = new TerminDBAdapter();
            arztDBAdapter = new ArztDBAdapter();
            berichtDBAdapter= new BerichtDBAdapter();
            patientDBAdapter= new PatientDBAdapter();

            termine = new List<Termin>();
            patienten = new List<Patient>();

    }

        /// <summary>
        /// Gibt die Form, die beim Starten des Programms gezeigt werden soll
        /// </summary>
        /// <returns>initiale Form</returns>
        public Form startProgram()
        {
            return loginForm;
        }

        /// <summary>
        /// Lädt Daten und navigiert von der LoginForm zur ArztOverviewForm
        /// </summary>
        /// <param name="loggedInArzt">angemeldeter Arzt</param>
        public void navLoginToArztOverview(Arzt loggedInArzt)
        {
            this.loggedInArzt = loggedInArzt;
            patienten = patientDBAdapter.getAllPatienten();
            termine = terminDBAdapter.getTermineOfArzt(loggedInArzt.idArzt);
            loginForm.Hide();
            arztOverview.Show();
        }

        /// <summary>
        /// Navigation von der ArztOverviewForm zur PatientOverviewForm
        /// </summary>
        public void navArztOverviewToPatientOverview()
        {
            arztOverview.Hide();
            patientOverviewForm.Show();
        }

        /// <summary>
        /// Navigation von der PatientOverviewForm zur NeuerTerminForm
        /// </summary>
        public void navPatientOverviewToNeuerTermin()
        {
            neuerTerminForm.Show();
        }

        public void berichtBackToPat()
        {
            berichtForm.Hide();
            patientOverviewForm.Show();
        }

        public void berichtSearchBericht()
        {
            berichtForm.Hide();
            berichtDatenForm.Show();
            
        }

        public void berichtAddBericht()
        {
            berichtForm.Hide();
            neuerBerichtForm.Show();
        }

        public void berichtBearbeitenSaveChange()
        {
            berichtBearbeitenForm.Hide();
            berichtForm.Show();
        }

        public void berichtBearbeitenClose()
        {
            //Fertig - Ungestestet
            berichtBearbeitenForm.Hide();
            berichtForm.Show();
        }

        public void berichtDatenChange()
        {
            //Fertig - Ungestestet
            berichtDatenForm.Hide();
            berichtBearbeitenForm.Show();
        }

        public void berichtDatenBack()
        {
            //Fertig - Ungestestet
            berichtDatenForm.Hide();
            berichtForm.Show();
        }

        public void neuerBerichtAddBericht()
        {
            //Fertig - Ungestestet
            neuerBerichtForm.Hide();
            berichtForm.Show();
        }

        public void neuerBerichtClose()
        {
            //Fertig - Ungestestet
            neuerBerichtForm.Hide();
            berichtForm.Show();
        }

        /// <summary>
        /// Navigation von der NeuerPatientForm zur PatientOverviewForm, wenn neuer Patient hinzugefügt wurde
        /// </summary>
        /// <param name="patient">der neue Patient</param>
        public void navNeuerPatientToPatientOverview(Patient patient)
        {
            patienten.Add(patientDBAdapter.createPatient(patient));
            navNeuerPatientToPatientOverview();
        }

        /// <summary>
        /// Navigation von der NeuerPatientForm zur PatientOverviewForm
        /// </summary>
        public void navNeuerPatientToPatientOverview()
        {
            neuerPatientForm.Close();
            patientOverviewForm.Show();
        }

        /// <summary>
        /// Navigation von der NeuerTerminForm zur PatientOverviewForm, wenn neuer Termin hinzugefügt wurde
        /// </summary>
        /// <param name="termin"der neue Termin></param>
        public void navNeuerTerminToPatientOverview(Termin termin)
        {
            termine.Add(terminDBAdapter.addTermin(termin));
            navNeuerTerminToPatientOverview();
        }

        /// <summary>
        /// Navigation von der NeuerTerminForm zur PatientOverviewForm
        /// </summary>
        public void navNeuerTerminToPatientOverview()
        {
            neuerTerminForm.Hide();
        }

        public void neuerTerminSearchPatient()
        {
            neuerTerminForm.Hide();
            patientOverviewForm.Show();
        }

        public void patientBearbeitenSaveChange()
        {
            //Fertig - Ungestestet
            patientBearbeitenForm.Hide();
            patientOverviewForm.Show();
        }

        public void patientBearbeitenClose()
        {
            //Fertig - Ungestestet
            patientBearbeitenForm.Hide();
            patientOverviewForm.Show();
        }

        /// <summary>
        /// Navigation von der PatientOverviewForm zur ArztOverviewForm
        /// </summary>
        public void navPatientOverviewToArztOverview()
        {
            patientOverviewForm.Hide();
            arztOverview.Show();
        }

        public void patientSearchPat()
        {
            //Fertig - Ungestestet
            patientOverviewForm.Hide();
            patientenDatenForm.Show();
        }

        /// <summary>
        /// Navigation von der PatientOverviewForm zur NeuerPatientForm
        /// </summary>
        public void navPatientOverviewToNeuerPatient()
        {
            patientOverviewForm.Hide();
            neuerPatientForm.Show();
        }

        public void patientDatenChangePat()
        {
            //Fertig - Ungestestet
            patientenDatenForm.Hide();
            patientBearbeitenForm.Show();
        }

        public void patientDatenOpenBerichte()
        {
            //Fertig - Ungestestet
            patientenDatenForm.Hide();
            berichtDatenForm.Show();
        }

        public void patientDatenBack()
        {
            //Fertig - Ungestestet
            patientenDatenForm.Hide();
            patientOverviewForm.Show();
        }

        public void terminBearbeitenSaveChange()
        {
            //Fertig - Ungestestet
            terminBearbeitenForm.Hide();
            arztOverview.Show();
        }

        public void terminBearbeitenClose()
        {
            //Fertig - Ungestestet
            terminBearbeitenForm.Hide();
            arztOverview.Show();
        }

        public void terminDatenChangeTermin()
        {
            //Fertig - Ungestestet
            terminDatenForm.Hide();
            terminBearbeitenForm.Show();
        }

        public void terminDatenDeleteTermin()
        {
            //Fertig - Ungestestet
            terminDatenForm.Hide();
            arztOverview.Show();
        }

        public void terminDatenClose()
        {
            //Fertig - Ungestestet
            terminDatenForm.Hide();
            arztOverview.Show();
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

        public List<Patient> searchPatient(string vorname)
        {
            return patientDBAdapter.getPatient(vorname);
        }

        public List<Patient> getPatienten()
        {
            return patienten;
        }

        public List<Termin> getTermine()
        {
            return termine;
        }

        /// <summary>
        /// Gibt den aktuell angemeldeten Arzt zurück
        /// </summary>
        /// <returns>Arzt</returns>
        public Arzt getLoggedInArzt()
        {
            return loggedInArzt;
        }

        /// <summary>
        ///  Gibt den aktuell selektierten Patient zurück
        /// </summary>
        /// <returns>Patient</returns>
        public Patient getCurrentSelectedPatient()
        {
            return currentSelectedPatient;
        }

        /// <summary>
        ///  Setz die idPatient des aktuell selektierten Patienten
        /// </summary>
        /// <param name="currentSelectedIdPatient">Patient</param>
        public void setcurrentSelectedPatient(Patient currentSelectedPatient)
        {
            this.currentSelectedPatient= currentSelectedPatient;
        }


    }
}
