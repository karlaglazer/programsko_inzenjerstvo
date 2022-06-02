using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava
{
    internal class UpraviteljLozinkama
    {
        private List<string> ListaLozinki = new List<string> { "1;abc111", "2;abc222" };

        public string DohvatiLozinku(int idKorisnika)
        {
            string lozinka = null;
            foreach (var loz in ListaLozinki)
            {
                string[] polje = loz.Split(';');
                if(polje[0] == idKorisnika.ToString())
                {
                    lozinka = polje[1];
                }
            }
            return lozinka;
        }
    }
}
