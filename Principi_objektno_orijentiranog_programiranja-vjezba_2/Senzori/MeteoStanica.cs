using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori_1
{
    internal class MeteoStanica
    {
        private List<Senzor> senzori;
        public MeteoStanica()
        {
            senzori = new List<Senzor>();
            senzori.Add(new Senzor("Senzor 1", 8.4, JedinicaMjere.Celzius));
            senzori.Add(new Senzor("Senzor 2", 281.5, JedinicaMjere.Kelvin));
            senzori.Add(new Senzor("Senzor 3", 8.9, JedinicaMjere.Celzius));
            senzori.Add(new Senzor("Senzor 4", 9.1, JedinicaMjere.Celzius));
        }
        private double Pretvori(JedinicaMjere izJedinice, double vrijednost)
        {
            double pretvori = 0;
            if (izJedinice == JedinicaMjere.Celzius)
            {
                pretvori = vrijednost + 273.15;
            }
            else if(izJedinice == JedinicaMjere.Kelvin)
            {
                pretvori = vrijednost - 273.15;
            }
            return pretvori;
        }
        public double DohvatiProsjecnuTemperaturu(JedinicaMjere jedinica)
        {
            double zbroj = 0;
            foreach(Senzor s in senzori)
            {
                if(s.Jedinica == jedinica)
                {
                    zbroj += s.Vrijednost;
                }
                else
                {
                    double pretvoreno = Pretvori(s.Jedinica, s.Vrijednost);
                    zbroj += pretvoreno;
                }
            }
            double prosjecna = zbroj / senzori.Count;
            return prosjecna;
        }
    }
}
