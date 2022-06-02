using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    internal class StreamingServis
    {
        public List<Film> DohvatiZapoceteFilmove()
        {
            KatalogFilmova katalogFilmova = new KatalogFilmova();
            List<Film> sviFilmovi = katalogFilmova.DohvatiSveFilmove();
            PovijestGledanja povijestGledanja = new PovijestGledanja();
            List<PogledaniFilm> pogledaniFilmovi = povijestGledanja.DohvatiPogledaneFilmove();
            List<Film> zapocetiFilmovi = new List<Film>();
            foreach (var film in sviFilmovi)
            {
                foreach (var pogledani in pogledaniFilmovi)
                {
                    if(film.ID == pogledani.IdFilma && film.Trajanje > pogledani.TrenutnaMinuta)
                    {
                        zapocetiFilmovi.Add(film);
                    }
                }

            }
            return zapocetiFilmovi;
        }
    }
}
