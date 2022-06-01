using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predlaganje_filma
{
    internal class StreamingServis
    {
        static Film film = new Film();
        public List<Film> Filmovi;
        public StreamingServis()
        {
            Filmovi = new List<Film>();
            Filmovi.Add(new Film("Film 1", ZanrFilma.Komedija, 88, false));
            Filmovi.Add(new Film("Film 2", ZanrFilma.Akcija, 95, false));
            Filmovi.Add(new Film("Film 3", ZanrFilma.Horor, 70, true));
            Filmovi.Add(new Film("Film 4", ZanrFilma.Komedija, 120, false));
            Filmovi.Add(new Film("Film 5", ZanrFilma.Akcija, 110, true));
            Filmovi.Add(new Film("Film 6", ZanrFilma.Horor, 99, false));
            Filmovi.Add(new Film("Film 7", ZanrFilma.Komedija, 75, false));
            Filmovi.Add(new Film("Film 8", ZanrFilma.Akcija, 80, false));
            Filmovi.Add(new Film("Film 9", ZanrFilma.Horor, 81, false));
            Filmovi.Add(new Film("Film 10", ZanrFilma.Komedija, 99, true));
        }
        private List<Film> DohvatiFilmoveKojeNisamGledao()
        {
            List<Film> list = new List<Film>();
            foreach(Film f in Filmovi)
            {
                if (f.VecGledan == false)
                {
                    list.Add(f);
                }
            }
            return list;
        }
        public void PredloziFilm()
        {
            List<Film> lista = DohvatiFilmoveKojeNisamGledao();
            var broj = new Random();
            int b = broj.Next(lista.Count);
            Console.WriteLine(film.DohvatiInfo(lista[b]));
        }
    }
}
