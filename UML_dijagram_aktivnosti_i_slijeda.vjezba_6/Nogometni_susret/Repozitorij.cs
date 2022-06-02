using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometni_Susret
{
    internal class Repozitorij
    {
        private List<Reprezentacija> Popisreprezentacija = new List<Reprezentacija>() 
        { new Reprezentacija {Oznaka = "HRV", Naziv = "Hrvatska"},
            new Reprezentacija {Oznaka ="GER", Naziv = "Njemačka"},
            new Reprezentacija {Oznaka ="FRA", Naziv = "Francuska"}
        };
        public Reprezentacija DohvatiReprezentaciju(string oznakaReprezentacije)
        {
            Reprezentacija reprezentacija = null;
            foreach (var rep in Popisreprezentacija)
            {
                if (oznakaReprezentacije == rep.Oznaka)
                {
                    reprezentacija = rep;
                }
            }
            return reprezentacija;
        }
    }
}
