using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patientenverwaltung;
using Patientenverwaltung.Model;
using Patientenverwaltung.Datenbank;
using Patientenverwaltung.Gui;
using Bericht = Patientenverwaltung.Gui.Bericht;

namespace Patientenverwaltung
{
    
    class Controller
    {
        
        Bericht bericht = new Bericht();
        BerichtBearbeiten berichtBearbeiten = new BerichtBearbeiten();
        BerichtDaten_cs berichtDaten = new BerichtDaten_cs();
        NeuerBericht neuerBericht = new NeuerBericht();
        NeuerPatient neuerPatient = new NeuerPatient();
        NeuerTermin neuerTermin = new NeuerTermin();
        PatientBearbeiten patientBearbeiten = new PatientBearbeiten();
        Patienten patient = new Patienten();
        PatientenDaten patientenDaten = new PatientenDaten();
        TerminBearbeiten terminBearbeiten = new TerminBearbeiten ();
        TerminDaten terminDaten = new TerminDaten ();
        DBAdapter adapter = new DBAdapter();

        public List<Termin> GetTerminArzt(int idArzt)
        {
            return adapter.getTermineOfArzt(idArzt);            

        }
        public List<Termin> GetTerminPatient(int idPatient)
        {
            return adapter.getTermineOfPatient(idPatient);
        }

        public List<Bericht> GetBericht(int idPatient)
        {
            return null;
        }

        public List<Krankheitsbild> GetKrankheiten(int idPatient)
        {
            return null;
        }
        

    }
}
