using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Banka : Transakcija
    {
        private List<Racun> racuni;
        public Banka()
        {
            racuni = new List<Racun>();
            racuni.Add(new Racun("HR11", 100000));
            racuni.Add(new Racun("HR22", 50000));
            racuni.Add(new Racun("HR33", 12000));
            racuni.Add(new Racun("HR44", 36000));
        }
        private Racun DohvatiRacun(string iban)
        {
            Racun racun = null;
            foreach (Racun r in racuni)
            {
                if (iban == r.IBAN)
                {
                    racun = r;
                }
            }
            return racun;
        }
        public Transakcija IzvrsiPlacanje(string platitelj, string primatelj, double iznos)
        {
            Transakcija transakcija = new Transakcija();
            transakcija.Platitelj = DohvatiRacun(platitelj);
            transakcija.Primatelj = DohvatiRacun(primatelj);
            transakcija.Iznos = iznos;
            transakcija.Platitelj.Stanje -= iznos;
            transakcija.Primatelj.Stanje += iznos;
           
            return transakcija;

            
        }
    }
}
