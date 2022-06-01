using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodovi_na_vježbama
{
    internal class Vjezba
    {
        protected int Broj { get; set; }
        protected string Naziv { get; set; }

        public Vjezba(int broj, string naziv)
        {
            Broj = broj;
            Naziv = naziv; 
        }
    }
}
