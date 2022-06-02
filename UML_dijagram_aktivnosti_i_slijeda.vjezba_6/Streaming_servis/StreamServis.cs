using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_servis
{
    internal class StreamServis
    {
        private KatalogFilmova katalogFilmova = new KatalogFilmova();
        private List<Film> neodgledaniFilmovi = new List<Film>();
        private List<Film> svi = new List<Film>();
        public List<Film> DohvatiNeodgledaneFilmove()
        {
            svi = katalogFilmova.DohvatiSveFilmove();
            List<PogledaniFilm> pogledaniFilmovi = katalogFilmova.DohvatiPogledaneFilmove();
            foreach (var film in svi)
            {
                bool neodgledan = true;
                foreach (var film2 in pogledaniFilmovi)
                {
                    if(film.Id == film2.IdFilma)
                    {
                        neodgledan = false;
                    }

                }
                if (neodgledan == true)
                {
                    neodgledaniFilmovi.Add(film);
                }
            }
            return neodgledaniFilmovi;
        }

        public void PogledajFilm(Film odabraniFilm)
        {
            PogledaniFilm noviPogledaniFilm = new PogledaniFilm(odabraniFilm.Id);
            katalogFilmova.DodajPogledaniFilm(noviPogledaniFilm);
        }
    }
}
