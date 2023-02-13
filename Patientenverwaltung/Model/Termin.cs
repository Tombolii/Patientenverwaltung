using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patientenverwaltung;
using Patientenverwaltung.Gui;

namespace Patientenverwaltung.Model
{
    public class Termin
    {

        private int _idTermin;

        public int idTermin
        {
            get { return _idTermin; }
            set { _idTermin = value; }
        }

        private DateTime _zeitpunkt;

        public DateTime zeitpunkt
        {
            get { return _zeitpunkt; }
            set { _zeitpunkt = value; }
        }

        private Arzt _arzt;

        public Arzt arzt
        {
            get { return _arzt; }
            set { _arzt = value; }
        }

        private Patient _patient;

        public Patient patient
        {
            get { return _patient; }
            set { _patient = value; }
        }


    }
}
