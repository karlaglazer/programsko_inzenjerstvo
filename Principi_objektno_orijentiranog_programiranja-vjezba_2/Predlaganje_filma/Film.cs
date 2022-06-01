using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predlaganje_filma
{
    enum ZanrFilma { Komedija, Akcija, Horor}
    internal class Film
    {
        public string Naziv { get; set; }
        public ZanrFilma Zanr { get; set; }
        public int Trajanje { get; set; }
        public bool VecGledan { get; set; }
        public Film()
        {

        }
        public Film(string naziv, ZanrFilma zanr, int trajanje, bool gledan)
        {
            Naziv = naziv;
            Zanr = zanr;
            Trajanje = trajanje;
            VecGledan = gledan;
        }
        public string DohvatiInfo(Film film)
        {
            string podaci = $"{film.Naziv} ({film.Zanr}, {film.Trajanje} min)";
            return podaci;
        }
    }
}
