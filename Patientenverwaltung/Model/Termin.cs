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

        private int _idArzt;

        public int idArzt
        {
            get { return _idArzt; }
            set { _idArzt = value; }
        }

        private SimplePatient _simplePatient;

        public SimplePatient simplePatient
        {
            get { return _simplePatient; }
            set { _simplePatient = value; }
        }
    }
}
