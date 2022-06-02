using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    internal static class Repozitorij
    {
        private static List<Korisnik> popisKorisnika = new List<Korisnik>();
        public static bool DodajKorisnika(Korisnik noviKorisnik)
        {
            foreach (var korisnik in popisKorisnika)
            {
                if(noviKorisnik.Ime ==korisnik.Ime && noviKorisnik.Prezime == korisnik.Prezime)
                {
                    return false;
                }
            }
            popisKorisnika.Add(noviKorisnik);
            return true;
        }
    }
}
