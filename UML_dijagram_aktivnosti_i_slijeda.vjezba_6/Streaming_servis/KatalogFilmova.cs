using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_servis
{
    internal class KatalogFilmova
    {
        public List<Film> SviFilmovi { get; set; } = new List<Film>()
        {
            new Film {Id =1, Naziv = "Batman"},
            new Film {Id =2, Naziv = "Superman"},
            new Film {Id =3, Naziv = "Spiderman"},
            new Film {Id =4, Naziv = "Ironman"},
            new Film {Id =5, Naziv = "Hulk"}
        };

        private List<PogledaniFilm> pogledaniFilmovi = new List<PogledaniFilm>();
        public List<Film> DohvatiSveFilmove()
        {
            return SviFilmovi;
        }
        public List<PogledaniFilm> DohvatiPogledaneFilmove()
        {
            return pogledaniFilmovi;
        }

        public void DodajPogledaniFilm(PogledaniFilm noviPogledaniFilm)
        {
            pogledaniFilmovi.Add(noviPogledaniFilm);
        }
        
    }
}
