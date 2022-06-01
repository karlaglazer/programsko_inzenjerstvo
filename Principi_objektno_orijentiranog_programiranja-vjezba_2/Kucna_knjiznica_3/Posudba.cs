using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Posudba
    {
        public string Osoba { get; set; }
        public Knjiga PosudjenaKnjiga { get; set; }
        public DateTime Datum { get; set; }
        public Posudba()
        {

        }
        public Posudba(string osoba, Knjiga posudenaKnjiga)
        {
            Osoba = osoba;
            PosudjenaKnjiga = posudenaKnjiga;
            Datum = DateTime.Now;
        }
        

        
    }
}
