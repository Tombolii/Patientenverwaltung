using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Model
{
    internal class Personendaten
    {
        private int _idPersonendaten;

        public int idPersonendaten
        {
            get { return _idPersonendaten; }
            set { _idPersonendaten = value; }
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

        private Adresse _adresse;

        public Adresse adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private int _telefonnummer;

        public int telefonnummer
        {
            get { return _telefonnummer; }
            set { _telefonnummer = value; }
        }

        private DateTime _geburtstag;

        public DateTime geburtstag
        {
            get { return _geburtstag; }
            set { _geburtstag = value; }
        }

        private List<Termin> _termine;

        public List<Termin> termine
        {
            get { return _termine; }
            set { _termine = value; }
        }

    }
}
