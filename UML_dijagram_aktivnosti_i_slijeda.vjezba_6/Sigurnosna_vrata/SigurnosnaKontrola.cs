using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnosna_vrata
{
    internal class SigurnosnaKontrola
    {
        public bool OtvoriVrata(int brKartice, int pin, int brVrata)
        {
            Repozitorij repozitorij = new Repozitorij();
            Korisnik korisnik = repozitorij.DohvatiKorisnika(brKartice, pin);

            Vrata vrata = repozitorij.DohvatiVrata(brVrata);

            if(korisnik.RazinaPrava >= vrata.RazinaPrava)
            {
                return true;
            }
            return false;
        }
    }
}
