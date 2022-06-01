using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Potvrda
    {
        public DateTime Datum { get; set; }
        public double Iznos { get; set; }
        public double Tecaj { get; set; }
        public double Preracunato { get; set; }
        public double Naknada { get; set; }
        public double Isplata { get; set; }
        public Potvrda(double iznos, double tecaj, double preracunato)
        {
            Datum = DateTime.Now;
            Iznos = iznos;
            Tecaj = tecaj;
            Preracunato = preracunato;
            Naknada = preracunato * 0.05;
            Isplata = preracunato - (preracunato*0.05);
        }
    }
}
