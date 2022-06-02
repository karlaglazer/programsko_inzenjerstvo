using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnosna_vrata
{
    internal class Repozitorij
    {
        private List<Korisnik> listaKorisnika = new List<Korisnik>() 
        {   new Korisnik { BrojKartice = 10001, PIN = 1234, RazinaPrava = 1 }, 
            new Korisnik { BrojKartice = 10002, PIN = 0000, RazinaPrava = 2 }, 
            new Korisnik { BrojKartice = 10003, PIN = 9999, RazinaPrava = 2 } 
        };
        private List<Vrata> listaVrata = new List<Vrata>() 
        {   new Vrata{BrojVrata = 501, RazinaPrava = 1},
            new Vrata{BrojVrata = 502, RazinaPrava= 2},
            new Vrata{BrojVrata = 503, RazinaPrava = 2}
        };

        public Korisnik DohvatiKorisnika(int brKartice, int pin)
        {
            Korisnik dohvaceniKorisnik = null;
            foreach (var korisnik in listaKorisnika)
            {
                if(brKartice == korisnik.BrojKartice && pin == korisnik.PIN)
                {
                    dohvaceniKorisnik = korisnik;
                }
            }
            return dohvaceniKorisnik;
        }
        public Vrata DohvatiVrata(int brVrata)
        {
            Vrata vrata = null;
            foreach (var v in listaVrata)
            {
                if(brVrata == v.BrojVrata)
                {
                    vrata = v;
                }
            }
            return vrata;
        }
    }
}
