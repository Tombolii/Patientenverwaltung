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
        private ArztOverviewForm arztOverview;
        private BerichtOverviewForm berichtOverviewForm;
        private BerichtBearbeitenForm berichtBearbeitenForm;
        private BerichtDatenForm berichtDatenForm;
        private NeuerBerichtForm neuerBerichtForm;
        private NeuerPatientForm neuerPatientForm;
        private NeuerTerminForm neuerTerminForm;
        private PatientBearbeitenForm patientBearbeitenForm;
        private PatientOverviewForm patientOverviewForm;
        private PatientenDatenForm patientenDatenForm;
        private TerminBearbeitenForm terminBearbeitenForm;
        private TerminDatenForm terminDatenForm;
        private LoginForm loginForm;
        DeleteConfirmationPopupForm deleteConfirmationPopupForm;

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
            berichtOverviewForm = new BerichtOverviewForm(this);
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
            deleteConfirmationPopupForm = new DeleteConfirmationPopupForm(this);

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
        public void navLoginToArztOverview(int loggedInArztId)
        {
            loggedInArzt = getArztById(loggedInArztId);
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

        /// <summary>
        /// Navigation von der BerichtOverviewForm zur PatientenDatenForm
        /// </summary>
        public void navBerichtOverviewToPatientenDaten()
        {
            berichtOverviewForm.Hide();
            patientenDatenForm.Show();
        }

        public void berichtAddBericht()
        {
            berichtOverviewForm.Hide();
            neuerBerichtForm.Show();
        }

        public void berichtBearbeitenSaveChange()
        {
            berichtBearbeitenForm.Hide();
            berichtOverviewForm.Show();
        }

        public void berichtBearbeitenClose()
        {
            //Fertig - Ungestestet
            berichtBearbeitenForm.Hide();
            berichtOverviewForm.Show();
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
            berichtOverviewForm.Show();
        }

        public void neuerBerichtAddBericht()
        {
            //Fertig - Ungestestet
            neuerBerichtForm.Hide();
            berichtOverviewForm.Show();
        }

        public void neuerBerichtClose()
        {
            //Fertig - Ungestestet
            neuerBerichtForm.Hide();
            berichtOverviewForm.Show();
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
        /// Navigation von der NeuerTerminForm zur PatientenDatenForm, wenn neuer Termin hinzugefügt wurde
        /// </summary>
        /// <param name="termin"der neue Termin></param>
        public void navNeuerTerminToPatientenDaten(Termin termin)
        {
            termine.Add(terminDBAdapter.addTermin(termin));
            navNeuerTerminToPatientenDaten();
        }

        /// <summary>
        /// Navigation von der NeuerTerminForm zur PatientenDatenForm
        /// </summary>
        public void navNeuerTerminToPatientenDaten()
        {
            neuerTerminForm.Hide();
        }

        public void neuerTerminSearchPatient()
        {
            neuerTerminForm.Hide();
            patientOverviewForm.Show();
        }

        /// <summary>
        /// Navigation von der PatientBearbeitenForm zur PatientenDatenForm, wenn Patient aktualisiert wird
        /// </summary>
        /// <param name="updatedPatient">aktualisierter Patient</param>
        public void navPatientBearbeitenToPatientenDaten(Patient updatedPatient)
        {
            patienten.Remove(currentSelectedPatient);
            currentSelectedPatient = patientDBAdapter.modifyPatient(updatedPatient);
            patienten.Add(currentSelectedPatient);
            navPatientBearbeitenToPatientenDaten();
        }

        /// <summary>
        /// Navigation von der PatientBearbeitenForm zur PatientenDatenForm
        /// </summary>
        public void navPatientBearbeitenToPatientenDaten()
        {
            patientBearbeitenForm.Hide();
            patientenDatenForm.Show();
        }

        /// <summary>
        /// Navigation von der PatientOverviewForm zur ArztOverviewForm
        /// </summary>
        public void navPatientOverviewToArztOverview()
        {
            patientOverviewForm.Hide();
            arztOverview.Show();
        }

        /// <summary>
        /// Navigation von der PatientOverviewForm zur PatientenDatenForm
        /// </summary>
        public void navPatientOverviewToPatientenDaten()
        {
            patientOverviewForm.Hide();
            patientenDatenForm.Show();
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

        /// <summary>
        /// Navigation von der PatientenDatenForm zur PatientBearbeitenForm
        /// </summary>
        public void navPatientenDatenToPatientBearbeiten()
        {
            patientenDatenForm.Hide();
            patientBearbeitenForm.Show();
        }

        /// <summary>
        /// Navigation von der PatientenDatenForm zur BerichtOverviewForm
        /// </summary>
        public void navPatientenDatenToBerichtOverview()
        {
            patientenDatenForm.Hide();
            berichtOverviewForm.Show();
        }

        /// <summary>
        /// Navigation von der PatientenDatenForm zur DeleteConfirmationPopupForm
        /// </summary>
        public void navPatientenDatenToDeleteConfirmationPopup()
        {
            deleteConfirmationPopupForm.Show();
        }

        public void navPatientenDatenToPatientOverview()
        {
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

        /// <summary>
        /// Navigation von der DeleteConfirmationPopupForm zur PatientOverviewForm
        /// </summary>
        public void navDeleteConfirmationPopupToPatientOverview()
        {
            patientenDatenForm.Hide();
            deleteConfirmationPopupForm.Hide();
            patientOverviewForm.Show();
        }

        /// <summary>
        /// Navigation von der DeleteConfirmationPopupForm zur PatientenDatenForm
        /// </summary>
        public void navDeleteConfirmationPopupToPatientenDaten()
        {
            deleteConfirmationPopupForm.Hide();
            patientenDatenForm.Show();
        }

        public List<Termin> getTermineOfPatient(int idPatient)
        {
            return terminDBAdapter.getTermineOfPatient(idPatient);
        }

        /// <summary>
        /// Gibt alle Berichte des aktuell ausgewählten Patienten zurück
        /// </summary>
        /// <returns>List der Berichte</returns>
        public List<Bericht> getBerichteOfPatient()
        {
            return berichtDBAdapter.getBerichteOfPatient(currentSelectedPatient.idPatient);
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

        /// <summary>
        /// Löscht den aktuell ausgewählten Patient
        /// </summary>
        public void deletePatient()
        {
            patientDBAdapter.deletePatient(currentSelectedPatient.idPatient);
            patienten.Remove(currentSelectedPatient);
            currentSelectedPatient = null;
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

        private Arzt getArztById(int idArzt)
        {
            return arztDBAdapter.getArztById(idArzt);
        }


    }
}
