using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popis_zadataka_09
{
    internal class NoviZadatak
    {
        public Zadatak Zadatak { get; set; }
        public bool Crvena { get; set; }
        public NoviZadatak(string naziv, DateTime datum)
        {
            Zadatak = new Zadatak(naziv, datum);
            Crvena = ProvjeriRok(Zadatak.KrajnjiRok);
        }

        private bool ProvjeriRok(DateTime krajnjiRok)
        {
            if(krajnjiRok > DateTime.Now.AddDays(1))
            {
                return false;
            }
            return true;
        }
    }

}
