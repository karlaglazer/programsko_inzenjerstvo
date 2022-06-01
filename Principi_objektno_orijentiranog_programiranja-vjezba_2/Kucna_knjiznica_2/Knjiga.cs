using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_2
{
    internal class Knjiga
    {
        public string Naslov { get; set; }
        public bool Dostupno { get; set; }
        public string Osoba { get; set; }
        public Knjiga()
        {

        }
        public Knjiga(string naslov)
        {
            Naslov = naslov;
            Dostupno = true;
            Osoba = null;
        }
        public string DohvatiOpis()
        {
            string opis = $"Naslov: {Naslov}, Dostupno: {Dostupno}, Osoba: {Osoba}";
            return opis;
        }
    }
}
