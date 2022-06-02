using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    internal class PovijestGledanja
    {
        public List<PogledaniFilm> ListaPogledanihFilmova = new List<PogledaniFilm>()
        {
            new PogledaniFilm{IdFilma = 1, TrenutnaMinuta = 90},
            new PogledaniFilm{IdFilma = 2, TrenutnaMinuta = 70},
            new PogledaniFilm{IdFilma = 5, TrenutnaMinuta = 55}
        };

        public List<PogledaniFilm> DohvatiPogledaneFilmove()
        {
            return ListaPogledanihFilmova;
        }
        
    }
}
