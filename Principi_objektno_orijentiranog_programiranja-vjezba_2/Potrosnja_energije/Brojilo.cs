using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrošnja_energije
{
    enum TipBrojila { Voda, Struja, Plin}
    internal class Brojilo
    {
        public string Naziv { get; set; }
        public TipBrojila Tip { get; set; }
        private double Stanje { get; set; }
        private double zadnjeOcitanje { get; set; }
        public Brojilo()
        {

        }
        public Brojilo(string naziv, TipBrojila tip, double stanje, double zadnjeocitanje)
        {
            Naziv = naziv;
            Tip = tip;
            Stanje = stanje;
            zadnjeOcitanje = zadnjeocitanje;
        }
        public double OcitajPotrosnju(Brojilo brojilo)
        {
            double potroseno = 0;
            double stanje = brojilo.Stanje;
            double zadnje = brojilo.zadnjeOcitanje;
            potroseno = stanje - zadnje;
            return potroseno;
        }
    }
}
