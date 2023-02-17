using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Model
{
    public class SimplePatient
    {
        private int _idPatient;

        public int idPatient
        {
            get { return _idPatient; }
            set { _idPatient = value; }
        }

        private string _vorname;

        public string vorname
        {
            get { return _vorname; }
            set { _vorname = value; }
        }

        private string _nachname;

        public string nachname
        {
            get { return _nachname; }
            set { _nachname = value; }
        }
    }
}
