using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Tecaj
    {
        public string Valuta { get; set; }
        public double Tecajv { get; set; }
        public Tecaj(string valuta, double tecaj)
        {
            Valuta = valuta;
            Tecajv = tecaj;
        }
    }
}
