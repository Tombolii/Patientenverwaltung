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
        private NeuerBerichtForm neuerBerichtForm;
        private NeuerPatientForm neuerPatientForm;
        private NeuerTerminForm neuerTerminForm;
        private PatientBearbeitenForm patientBearbeitenForm;
        private PatientOverviewForm patientOverviewForm;
        private PatientenDatenForm patientenDatenForm;
        private TerminBearbeitenForm terminBearbeitenForm;
        private TerminDatenForm terminDatenForm;
        private LoginForm loginForm;
        private AdminForm adminForm;
        private DeletePatientConfirmationPopupForm deletePatientConfirmationPopupForm;
        private DeleteTerminConfirmationPopupForm deleteTerminConfirmationPopupForm;


        // Adapter
        private TerminDBAdapter terminDBAdapter;
        private ArztDBAdapter arztDBAdapter;
        private BerichtDBAdapter berichtDBAdapter;
        private PatientDBAdapter patientDBAdapter;
        private KrankheitsbildDBAdapter krankheitsbildDBAdapter;
        private VersicherungDBAdapter versicherungDBAdapter;
        private LoginDBAdapter loginDBAdapter;
        private AdresseDBAdapter adresseDBAdapter;
        private PersonendatenDBAdapter personendatenDBAdapter;

        private Arzt loggedInArzt;
        private Patient currentSelectedPatient;
        private Bericht currentSelectedBericht;
        private Termin currentSelectedTermin;
        private List<Termin> termine;
        private List<Patient> patienten;
        private List<Krankheitsbild> krankheitsbilder;
        private List<Versicherung> versicherungen;
        private List<PasswordInformation> pwdInformation;


        public Controller()
        {
            // GUI-Forms
            arztOverview = new ArztOverviewForm(this);
            berichtOverviewForm = new BerichtOverviewForm(this);
            berichtBearbeitenForm = new BerichtBearbeitenForm(this);
            neuerBerichtForm = new NeuerBerichtForm(this);
            neuerPatientForm = new NeuerPatientForm(this);
            neuerTerminForm = new NeuerTerminForm(this);
            patientBearbeitenForm = new PatientBearbeitenForm(this);
            patientOverviewForm = new PatientOverviewForm(this);
            patientenDatenForm = new PatientenDatenForm(this);
            terminBearbeitenForm = new TerminBearbeitenForm(this);
            terminDatenForm = new TerminDatenForm(this);
            loginForm = new LoginForm(this);
            adminForm = new AdminForm(this);
            deletePatientConfirmationPopupForm = new DeletePatientConfirmationPopupForm(this);
            deleteTerminConfirmationPopupForm = new DeleteTerminConfirmationPopupForm(this);    

            // Adapter
            terminDBAdapter = new TerminDBAdapter();
            arztDBAdapter = new ArztDBAdapter();
            berichtDBAdapter= new BerichtDBAdapter();
            patientDBAdapter= new PatientDBAdapter();
            krankheitsbildDBAdapter = new KrankheitsbildDBAdapter();
            versicherungDBAdapter = new VersicherungDBAdapter();
            loginDBAdapter = new LoginDBAdapter();
            adresseDBAdapter = new AdresseDBAdapter();
            personendatenDBAdapter = new PersonendatenDBAdapter();

        termine = new List<Termin>();
            patienten = new List<Patient>();
            versicherungen = new List<Versicherung>();
            krankheitsbilder = new List<Krankheitsbild>();
            pwdInformation = new List<PasswordInformation>();

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
        /// 
        public void navLoginToArztOverview(int loggedInArztId)
        {
            // Laden der Datensätze aus der DB
            loggedInArzt = getArztById(loggedInArztId);
            patienten = patientDBAdapter.getAllPatienten();
            termine = terminDBAdapter.getTermineOfArzt(loggedInArzt.idArzt);
            krankheitsbilder = krankheitsbildDBAdapter.getKrankheitsbilder();
            versicherungen = versicherungDBAdapter.getAllVersicherungen();
            
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
        /// Navigation von der ArztOverviewForm zur TerminDatenForm
        /// </summary>
        public void navArztOverviewToTerminDaten()
        {
            arztOverview.Hide();
            terminDatenForm.Show();
        }

        /// <summary>
        /// Navigation von der PatientOverviewForm zur NeuerTerminForm
        /// </summary>
        public void navPatientOverviewToNeuerTermin()
        {
            neuerTerminForm.Show();
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

        /// <summary>
        /// Navigation von der BerichtOverviewForm zur PatientenDatenForm
        /// </summary>
        public void navBerichtOverviewToPatientenDaten()
        {
            berichtOverviewForm.Hide();
            patientenDatenForm.Show();
        }

        /// <summary>
        /// Navigation von der BerichtOverviewForm zur BerichtBearbeitenForm
        /// </summary>
        public void navBerichtOverviewToBerichtBearbeiten()
        {
            berichtOverviewForm.Hide();
            berichtBearbeitenForm.Show();
        }

        /// <summary>
        /// Navigation von der BerichtBearbeitenForm zur BerichtOverviewForm
        /// </summary>
        public void navBerichtBearbeitenToBerichtOverview()
        {
            berichtBearbeitenForm.Hide();
            berichtOverviewForm.Show();
        }

        /// <summary>
        /// Navigation von der BerichtBearbeitenForm zur TerminDatenForm
        /// </summary>
        public void navBerichtBearbeitenToTerminDaten()
        {
            berichtBearbeitenForm.Hide();
            terminDatenForm.Show();
        }

        /// <summary>
        /// Navigation von der NeuerBerichtForm zur TerminDatenForm
        /// </summary>
        public void navNeuerBerichtToTerminDaten()
        {
            neuerBerichtForm.Hide();
            terminDatenForm.Show();
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
        /// Navigation von der PatientBearbeitenForm zur PatientenDatenForm
        /// </summary>
        public void navPatientBearbeitenToPatientenDaten()
        {
            patientBearbeitenForm.Hide();
            patientenDatenForm.Show();
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
            deletePatientConfirmationPopupForm.Show();
        }

        /// <summary>
        /// Navigation von der DeletePatientConfirmationPopupForm zur PatientOverviewForm
        /// </summary>
        public void navDeletePatientConfirmationPopupToPatientOverview()
        {
            patientenDatenForm.Hide();
            deletePatientConfirmationPopupForm.Hide();
            patientOverviewForm.Show();
        }

        /// <summary>
        /// Navigation von der DeletePatientConfirmationPopupForm zur PatientenDatenForm
        /// </summary>
        public void navDeletePatientConfirmationPopupToPatientenDaten()
        {
            deletePatientConfirmationPopupForm.Hide();
            patientenDatenForm.Show();
        }

        /// <summary>
        /// Navigation von der PatientenDatenForm zur PatientenOverviewForm
        /// </summary>
        public void navPatientenDatenToPatientOverview()
        {
            patientenDatenForm.Hide();
            patientOverviewForm.Show();
        }

        /// <summary>
        /// Navigation von der TerminBearbeitenForm zur TerminDatenForm, wenn Termin aktualisiert wurde
        /// </summary>
        public void navTerminBearbeitenToTerminDaten()
        {
            terminBearbeitenForm.Hide();
            terminDatenForm.Show();
        }

        /// <summary>
        /// Navigation von der TerminDatenForm zur TerminBearbeitenForm
        /// </summary>
        public void navTerminDatenToTerminBearbeiten()
        {
            terminDatenForm.Hide();
            terminBearbeitenForm.Show();
        }

        /// <summary>
        /// Navigation von der TerminDatenForm zur ArztOverviewForm
        /// </summary>
        public void navTerminDatenToArztOverview()
        {
            terminDatenForm.Hide();
            arztOverview.Show();
        }

        /// <summary>
        /// Navigation von der TerminDatenForm zur DeleteTerminConfirmationForm
        /// </summary>
        public void navTerminDatenToDeleteTerminConfirmationPopup()
        {
            deleteTerminConfirmationPopupForm.Show();
        }

        /// <summary>
        /// Navigation von der TerminDatenForm zur NeuerBerichtForm
        /// </summary>
        public void navTerminDatenToNeuerBericht()
        {
            terminDatenForm.Hide();
            neuerBerichtForm.Show();
        }

        /// <summary>
        /// Navigation von der NeuerTerminForm zur PatientenDatenForm
        /// </summary>
        public void navNeuerTerminToPatientenDaten()
        {
            neuerTerminForm.Hide();
        }

        /// <summary>
        /// Navigation von der TerminDatenForm zur BerichtDatenForm
        /// </summary>
        public void navTerminDatenToBerichtDaten()
        {
            
            berichtBearbeitenForm.Show();
        }

        /// <summary>
        /// Navigation von der DeleteTerminConfirmationPopupForm zur ArztOverviewForm
        /// </summary>
        public void navDeleteTerminConfirmationPopupToArztOverview()
        {
            terminDatenForm.Hide();
            deleteTerminConfirmationPopupForm.Hide();
            arztOverview.Show();
        }

        /// <summary>
        /// Navigation von der DeleteTerminConfirmationPopupForm zur TerminDatenForm
        /// </summary>
        public void navDeleteTerminConfirmationPopupToTerminDaten()
        {
            deleteTerminConfirmationPopupForm.Hide();
            terminDatenForm.Show();
        }

        /// <summary>
        /// Gibt alle Berichte des aktuell ausgewählten Patienten zurück
        /// </summary>
        /// <returns>List der Berichte</returns>
        public List<Bericht> getBerichteOfPatient()
        {
            return berichtDBAdapter.getBerichteOfPatient(currentSelectedPatient.idPatient);
        }

        /// <summary>
        /// Gibt einen bestimmten Bericht zurück
        /// </summary>
        /// <param name="idBericht">des gesuchten Berichts</param>
        /// <returns>den gesuchten Bericht</returns>
        public Bericht getBerichtById(int idBericht)
        {
            return berichtDBAdapter.getBericht(idBericht);
        }

        /// <summary>
        /// Löscht den aktuell ausgewählten Patient
        /// </summary>
        public void deletePatient()
        {
            patientDBAdapter.deletePatient(currentSelectedPatient);
            for (int i = 0; i < termine.Count; i++)
            {
                if (termine[i].simplePatient.idPatient == currentSelectedPatient.idPatient)
                {
                    termine.RemoveAt(i);
                }
            }
            patienten.Remove(currentSelectedPatient);
            currentSelectedPatient = null;
        }

        /// <summary>
        /// Löscht den aktuell ausgewählten Termin
        /// </summary>
        public void deleteCurrentTermin()
        {
            terminDBAdapter.deleteTermin(currentSelectedTermin);
            termine.Remove(currentSelectedTermin);
            currentSelectedTermin = null;
        }

        /// <summary>
        /// Erstellt einen neuen Bericht
        /// </summary>
        /// <param name="neuerBericht">der neue Bericht</param>
        public void createBericht(Bericht neuerBericht)
        {
            Bericht bericht = berichtDBAdapter.createBericht(neuerBericht);
            currentSelectedBericht = bericht;
            currentSelectedTermin.idBericht = bericht.idBericht;
            updateTermin(currentSelectedTermin);
        }

        /// <summary>
        /// Aktualisiert einen Bericht
        /// </summary>
        /// <param name="updatedBericht">aktualisierter Bericht</param>
        public void updateBericht(Bericht updatedBericht)
        {
            currentSelectedBericht = berichtDBAdapter.modifyBericht(updatedBericht);
        }

        /// <summary>
        /// Erstellt einen neuen Patient
        /// </summary>
        /// <param name="patient">der neue Patient</param>
        public void createPatient(Patient patient)
        {
            patienten.Add(patientDBAdapter.createPatient(patient));
        }

        /// <summary>
        /// Aktualisiert einen Patienten
        /// </summary>
        /// <param name="updatedPatient">aktualisierter Patient</param>
        public void updatePatient(Patient updatedPatient)
        {
            patienten.Remove(currentSelectedPatient);
            currentSelectedPatient = patientDBAdapter.modifyPatient(updatedPatient);
            patienten.Add(currentSelectedPatient);
        }

        /// <summary>
        /// Erstellt einen neuen Termin
        /// </summary>
        /// <param name="termin">der neue Termin</param>
        public void createTermin(Termin termin)
        {
            termine.Add(terminDBAdapter.addTermin(termin));
        }

        /// <summary>
        /// Aktualisiert einen Termin
        /// </summary>
        /// <param name="updatedTermin">aktualisierter Termin</param>
        public void updateTermin(Termin updatedTermin)
        {
            Termin updatedTerminOfDb = terminDBAdapter.modifyTermin(updatedTermin);
            currentSelectedTermin = updatedTerminOfDb;
        }

        public Arzt createArzt(Arzt arzt)
        {
            arzt.adresse = adresseDBAdapter.createNewAdresse(arzt.adresse);
            Personendaten newPerson = personendatenDBAdapter.createNewPersonendaten(arzt, arzt.adresse.idAdresse);
            arzt.idPersonendaten = newPerson.idPersonendaten;

            arztDBAdapter.createNewArzt(arzt);
            return arzt;
        }

        private Arzt getArztById(int idArzt)
        {
            return arztDBAdapter.getArztById(idArzt);
        }

        public Arzt getLoggedInArzt()
        {
            return loggedInArzt;
        }

        public List<Krankheitsbild> getKrankheitsbilder()
        {
            return krankheitsbilder;
        }

        public List<Versicherung> getVersicherungen()
        {

            return versicherungen;
        }

        public List<Termin> getTermine()
        {
            return termine;
        }

        public List<Patient> getPatienten()
        {
            return patienten;
        }

        public Patient getCurrentSelectedPatient()
        {
            return currentSelectedPatient;
        }

        public void setCurrentSelectedPatient(Patient currentSelectedPatient)
        {
            this.currentSelectedPatient = currentSelectedPatient;
        }

        public void setCurrentSelectedBericht(Bericht currentSelectedBericht)
        {
            this.currentSelectedBericht = currentSelectedBericht;
        }

        public Bericht getCurrentSelectedBericht()
        {
            return currentSelectedBericht;
        }

        /// <summary>
        /// Setzt den aktuell ausgewählten Bericht und falls für diesen bereits ein Bericht existiert, wird dieser ebenfalls als markiert gesetzt
        /// </summary>
        /// <param name="currentSelectedTermin">ausgewählter Termin</param>
        public void setCurrentSelectedTermin(Termin currentSelectedTermin)
        {
            this.currentSelectedTermin = currentSelectedTermin;
            if(currentSelectedTermin.idBericht != 0)
            {
                currentSelectedBericht = getBerichtById(currentSelectedTermin.idBericht);
            }
        }

        public Termin getCurrentSelectedTermin()
        {
            return currentSelectedTermin;
        }

        public bool verifyLogin(int arztID, string passwordForm)
        {
            PasswordInformation test = loginDBAdapter.getPassword(arztID);
            if (test.password == passwordForm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void navLoginToAdmin()
        {
            loginForm.Hide();
            adminForm.Show();
        }

        public void navAdminToLogin()
        {
            adminForm.Hide();
            loginForm.Show();
        }
    }
}
