using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija_članova
{
    internal class Registrator
    {
        static Validator validator = new Validator();
        private List<Clan> listaClanova;
        public Registrator()
        {
            listaClanova = new List<Clan>();
            listaClanova.Add(new Clan("pperic@foi.hr", "1111"));
            listaClanova.Add(new Clan("iivic@foi.hr", "2222"));
            listaClanova.Add(new Clan("jjuric@foi.hr", "3333"));
        }
        private bool EmailZauzet(string emailAdresa)
        {
            bool postoji = false;
            foreach(Clan c in listaClanova)
            {
                if (emailAdresa == c.EmailAdresa)
                {
                    postoji = true;
                }
            }
            return postoji;
        }
        public string RegistrirajClana(string email, string lozinka)
        {
            if (validator.ValidirajEmail(email) == false)
            {
                return "Email adresa je neispravnog oblika!";
            }
            else if(EmailZauzet(email)==false)
            {
                if (validator.ValidirajLozinku(lozinka) == false)
                {
                    return "Lozinka mora sadržavati između 6 i 10 znakova!";
                }
                else
                {
                    return "Clan je uspjesno registriran!";
                }
            }
            else
            {
                return "Već postoji član sa navedenim emailom!";
            }
            
        }
    }
}
