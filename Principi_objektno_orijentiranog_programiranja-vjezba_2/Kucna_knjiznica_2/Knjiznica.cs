using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_2
{
    internal class Knjiznica
    {
        public List<Knjiga> PopisKnjiga;
        public Knjiznica()
        {
            PopisKnjiga = new List<Knjiga>();
            PopisKnjiga.Add(new Knjiga("Prstenova druzina"));
            PopisKnjiga.Add(new Knjiga("Dvije kule"));
            PopisKnjiga.Add(new Knjiga("Povratak kralja"));
        }
        public void Posudi(string naslov, string osoba)
        {
            foreach(Knjiga k in PopisKnjiga)
            {
                if (k.Naslov == naslov)
                {
                    if (k.Dostupno == true)
                    {
                        k.Dostupno = false;
                        k.Osoba = osoba;
                    }
                }
            }
        }
    }
}
