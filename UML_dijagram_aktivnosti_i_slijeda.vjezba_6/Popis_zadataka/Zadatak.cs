using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popis_zadataka
{
    internal class Zadatak
    {
        public string Naziv { get; set; }
        public DateTime DatumIVrijeme { get; set; }
        public Zadatak(string naziv, DateTime datum)
        {
            Naziv = naziv;
            DatumIVrijeme = datum;
        }
    }
}
