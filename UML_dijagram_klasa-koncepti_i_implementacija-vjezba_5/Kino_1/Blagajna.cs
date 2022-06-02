using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino1
{
    internal class Blagajna
    {
        public List<Karta> ProdaneKarte { get; set; }

        public void KreirajKartu(Projekcija projekcija, Sjedalo sjedalo)
        {
            bool postoji = false;
            foreach (Karta karta in ProdaneKarte)
            {
                if (karta.OdabranaProjekcija == projekcija || karta.OdabranoSjedalo == sjedalo)
                {
                    postoji = true;
                }
            }
            if (postoji == false)
            {
                Karta karta = new Karta(projekcija, sjedalo);
                ProdaneKarte.Add(karta);
            }
        }
    }
}
