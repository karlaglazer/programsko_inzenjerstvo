using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija_članova
{
    internal class Validator
    {
        public Validator()
        {

        }
        public bool ValidirajEmail(string emailAdresa)
        {
            if (emailAdresa.Contains("@") && emailAdresa.Contains("foi.hr"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidirajLozinku(string lozinka)
        {
            if(lozinka.Length < 6 || lozinka.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
