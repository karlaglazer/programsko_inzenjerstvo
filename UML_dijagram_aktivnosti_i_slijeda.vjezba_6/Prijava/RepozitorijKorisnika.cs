using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava
{
    internal class RepozitorijKorisnika
    {
        private List<Korisnik> ListaKorisnika = new List<Korisnik> 
        {   new Korisnik{ID = 1, KorisnickoIme = "pperic"},
            new Korisnik{ID = 2, KorisnickoIme = "ihorvat"}
        };
        public Korisnik DohvatiKorisnika(string korIme)
        {
            Korisnik pronadeniKorisnik = null;
            foreach (var korisnik in ListaKorisnika)
            {
                if(korIme == korisnik.KorisnickoIme)
                {
                    pronadeniKorisnik = korisnik;
                }
            }
            return pronadeniKorisnik;
        }
    }
}
