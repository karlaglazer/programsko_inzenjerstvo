using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava
{
    internal class Autentifikator
    {
        public bool Prijavikorisnika(int idKorisnika, string lozinka)
        {
            UpraviteljLozinkama upraviteljLozinkama = new UpraviteljLozinkama();
            if(lozinka == upraviteljLozinkama.DohvatiLozinku(idKorisnika))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
