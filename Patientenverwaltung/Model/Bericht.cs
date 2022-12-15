using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Model
{
    internal class Bericht
    {
        private int _idBericht;

        public int idBericht
        {
            get { return _idBericht; }
            set { _idBericht = value; }
        }

        private Patient _patient;

        public Patient patient
        {
            get { return _patient; }
            set { _patient = value; }
        }

        private string _beschwerden;

        public string beschwerden
        {
            get { return _beschwerden; }
            set { _beschwerden = value; }
        }

        private string _bemerkung;

        public string bemerkung
        {
            get { return _bemerkung; }
            set { _bemerkung = value; }
        }

        private Krankheitsbild _diagnose;

        public Krankheitsbild diagnose
        {
            get { return _diagnose; }
            set { _diagnose = value; }
        }

    }
}
