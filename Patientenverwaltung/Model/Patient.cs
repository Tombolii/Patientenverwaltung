using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Model
{
    public class Patient : Personendaten
    {
        private int _idPatient;

        public int idPatient
        {
            get { return _idPatient; }
            set { _idPatient = value; }
        }

        private Versicherung _versicherung;

        public Versicherung versicherung
        {
            get { return _versicherung; }
            set { _versicherung = value; }
        }

        private List<Krankheitsbild> _vorerkrankungen;

        public List<Krankheitsbild> vorerkrankungen
        {
            get { return _vorerkrankungen; }
            set { _vorerkrankungen = value; }
        }

        private int _versicherungsnummer;

        public int versicherungsnummer
        {
            get { return _versicherungsnummer; }
            set { _versicherungsnummer = value; }
        }



    }
}
