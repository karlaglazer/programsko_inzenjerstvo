using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino2
{
    internal class Kino
    {
        public List<Dvorana> PopisDvorana { get; set; }
        public List<Projekcija> PopisProjekcija { get; set; }

        public List<Projekcija> DohvatiProjekcije(string naziv)
        {
            List<Projekcija> projekcija = new List<Projekcija>();
            foreach(Projekcija proj in PopisProjekcija)
            {
                if(proj.Datum ==DateTime.Now || proj.Predstava.Naziv == naziv)
                {
                    projekcija.Add(proj);
                }
            }
            return projekcija;
        }
    }
}
