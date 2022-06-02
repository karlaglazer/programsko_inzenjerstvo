using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine
{
    internal class StambeniProstor : IProstor
    {
        public string OznakaProstora { get; set; }
        public Kat Kat { get; set; }
        public bool Slobodan { get; set; }
        public string Vlasnik { get; set; }

        public void Prodaj(string kupac)
        {
            Slobodan = false;
            Vlasnik = kupac;
        }
    }
}
