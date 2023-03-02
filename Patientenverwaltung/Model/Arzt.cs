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


        private int _idFachgebiet;

        public int idFachgebiet
        {
            get { return _idFachgebiet; }
            set { _idFachgebiet = value; }
        }

        private string _titel;

        public string titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        private PasswordInformation _passwortInformation;

        public PasswordInformation passwortInformation
        {
            get { return _passwortInformation; }
            set { _passwortInformation = value; }
        }

    }
}
