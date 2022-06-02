using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino1
{
    internal class Karta
    {
        public Projekcija OdabranaProjekcija { get; set; }
        public Sjedalo OdabranoSjedalo { get; set; }
        public Karta(Projekcija projekcija, Sjedalo sjedalo)
        {
            OdabranaProjekcija = projekcija;
            OdabranoSjedalo = sjedalo;
        }

        public double OdrediCijenu()
        {
            if(OdabranaProjekcija.Premijera == true)
            {
                return 60;
            }
            else
            {
                return 40;
            }
        }
    }
}
