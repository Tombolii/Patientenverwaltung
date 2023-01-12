using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Model
{
    internal class Krankheitsbild
    {

        private int _idKrankheitsbild;

        public int idKrankheitsbild
        {
            get { return _idKrankheitsbild; }
            set { _idKrankheitsbild = value; }
        }

        private string _bezeichnung;

        public string bezeichnung
        {
            get { return _bezeichnung; }
            set { _bezeichnung = value; }
        }

        private string _symptome;

        public string symptome
        {
            get { return _symptome; }
            set { _symptome = value; }
        }
    }
}
