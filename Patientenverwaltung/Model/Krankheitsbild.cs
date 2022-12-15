using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Model
{
    internal class Krankheitsbild
    {

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
