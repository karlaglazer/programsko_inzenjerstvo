using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava_u_sustav
{
    internal class Autentifikator
    {
        private List<Korisnik> listaKorisnika;
        public Autentifikator()
        {
            listaKorisnika = new List<Korisnik>();
            listaKorisnika.Add(new Korisnik("pperic", "1111"));
            listaKorisnika.Add(new Korisnik("iivic", "2222"));
            listaKorisnika.Add(new Korisnik("jjuric", "3333"));
        }
        private Korisnik DohvatiKorisnika(string korisnickoIme)
        {
            Korisnik korisnik = null;
            foreach(Korisnik k in listaKorisnika)
            {
                if(k.KorisnickoIme == korisnickoIme)
                {
                    korisnik = k;
                }
            }
            return korisnik;
        }
        public string PrijaviKorisnika(string korisnickoIme, string lozinka)
        {
            string poruka = null;
            Korisnik korisnik = DohvatiKorisnika(korisnickoIme);
            if(korisnik == null)
            {
                poruka = "Ne postoji korisnik sa navedenim korisničkim imenom!";
            }
            else if(korisnik.Lozinka != lozinka)
            {
                poruka = "Pogrešno upisana lozinka!";
            }
            else
            {
                poruka = "Uspješno prijavljen korisnik!";
            }
            return poruka;
        }
    }
}
