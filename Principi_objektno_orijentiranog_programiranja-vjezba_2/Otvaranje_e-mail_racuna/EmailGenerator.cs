using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_e_mail_računa
{
    internal class EmailGenerator
    {
        public string GenerirajEmail(string ime, string prezime)
        {
            string email = ime.ToLower() + '.' + prezime.ToLower() + "@foi.hr";
            return email;
        }
        public string GenerirajSkraceniEmail(string ime, string prezime)
        {
            string email = ime.Substring(0,1).ToLower() + '.' + prezime.Substring(0,5).ToLower() + "@foi.hr";
            return email;
        }
    }
}
