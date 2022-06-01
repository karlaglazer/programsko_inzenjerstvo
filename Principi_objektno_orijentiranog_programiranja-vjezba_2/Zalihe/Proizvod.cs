using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Proizvod
    {
        public string Naziv { get; set; }
        public double JedinicnaCijena { get; set; }
        public double Stanje { get; set; }

        public Proizvod()
        {

        }
        public Proizvod(string naziv, double cijena, double stanje)
        {
            Naziv = naziv;  
            JedinicnaCijena = cijena;
            Stanje = stanje;
        }
        public double IzracunajVrijednostZaliha()
        {
            double vrijednost = Stanje * JedinicnaCijena;
            return vrijednost;
        }
        public void DodajNaStanje(double kolicina)
        {
            if(kolicina > 0)
            {
                Stanje+=kolicina;
            }
        }
        public void OduzmiSaStanja(double kolicina)
        {
            if(kolicina<0 || kolicina > Stanje)
            {
                Console.WriteLine("Ne moze");
            }
            else
            {
                Stanje-=kolicina;
            }
        }

    }
}
