using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popis_zadataka
{
    internal class NoviZadatak
    {
        public bool Crvena { get; set; }
        public Zadatak Zadatak { get; set; }
        public NoviZadatak(string naziv, DateTime datum)
        {
            Zadatak = new Zadatak(naziv, datum);
            Crvena = ProvjeriDatum(Zadatak);    
        }

        private bool ProvjeriDatum(Zadatak zadatak)
        {
            if (zadatak.DatumIVrijeme > DateTime.Now.AddDays(1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
