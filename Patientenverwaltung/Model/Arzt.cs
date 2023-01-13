using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Model
{
    public class Arzt : Personendaten
    {

        private int _idArzt;

        public int idArzt
        {
            get { return _idArzt; }
            set { _idArzt = value; }
        }


        private string _fachgebiet;

        public string fachgebiet
        {
            get { return _fachgebiet; }
            set { _fachgebiet = value; }
        }

        private string _titel;

        public string titel
        {
            get { return _titel; }
            set { _titel = value; }
        }


    }
}
