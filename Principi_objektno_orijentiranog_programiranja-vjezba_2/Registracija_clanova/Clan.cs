using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija_članova
{
    internal class Clan
    {
        public string EmailAdresa { get; set; }
        public string Lozinka { get; set; }
        
        public Clan(string email, string lozinka)
        {
            EmailAdresa = email;
            Lozinka = lozinka;
        }
    }
}
