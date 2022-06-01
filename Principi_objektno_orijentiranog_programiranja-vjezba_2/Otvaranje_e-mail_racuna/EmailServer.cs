using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_e_mail_računa
{
    internal class EmailServer
    {
        static EmailGenerator emailG = new EmailGenerator();
        static LozinkaGenerator lozinkaG = new LozinkaGenerator();
        public KorisnickiRacun KreirajKorisnickiRacun(string ime, string prezime)
        {
            string email = emailG.GenerirajEmail(ime, prezime); 
            string skraceniEmail = emailG.GenerirajSkraceniEmail(ime, prezime);
            string lozinka = lozinkaG.GenerirajLozinku(ime, prezime);
            KorisnickiRacun kRacun = new KorisnickiRacun(ime, prezime, email, skraceniEmail, lozinka);
            return kRacun;

        }
    }
}
