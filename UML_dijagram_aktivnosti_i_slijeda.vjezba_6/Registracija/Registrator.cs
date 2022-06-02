using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    internal class Registrator
    {
        public bool Registriraj(string ime, string prezime)
        {
            Generator generator = new Generator();
            string email = generator.GenerirajEmail(ime, prezime);
            int lozinka = generator.GenerirajLozinku();
            Korisnik noviKorisnik = new Korisnik(ime, prezime, email, lozinka);
            if (Repozitorij.DodajKorisnika(noviKorisnik) == false)
            {
                return false;
            }
            return true;
        }
    }
}
