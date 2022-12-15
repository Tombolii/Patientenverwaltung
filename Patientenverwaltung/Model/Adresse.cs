﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Model
{
    internal class Adresse
    {

        private string _straße;

        public string straße
        {
            get { return _straße; }
            set { _straße = value; }
        }

        private string _ort;

        public string ort
        {
            get { return _ort; }
            set { _ort = value; }
        }


        private int _plz;

        public int plz
        {
            get { return _plz; }
            set { _plz = value; }
        }



    }
}
