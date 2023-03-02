using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung.Model
{
    public class PasswordInformation
    {
        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _passwordSalt;

        public string passwordSalt
        {
            get { return _passwordSalt; }
            set { _passwordSalt = value; }
        }


    }
}
