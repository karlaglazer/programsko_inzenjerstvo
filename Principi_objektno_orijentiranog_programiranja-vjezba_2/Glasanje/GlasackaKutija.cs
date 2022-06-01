using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class GlasackaKutija
    {
        private List<Glas> glasovi = new List<Glas>();
        private bool VecGlasao(string oib)
        {
            bool postoji=false; 
            foreach(Glas g in glasovi)
            {
                if (g.OIB == oib)
                {
                    postoji=true;
                }
            }
            return postoji;
        }
        public void Glasaj(string oib, string odabir)
        {
            if (VecGlasao(oib) == false)
            {
                glasovi.Add(new Glas(oib, odabir));
                Console.WriteLine("Uspješno ste glasali!");
            }
        }
        public void DohvatiRezultateGlasanja()
        {
            int za = 0;
            int protiv = 0;
            int suzdrzan = 0;
            foreach (Glas g in glasovi)
            {
                if (g.Odabir == "Z")
                {
                    za++;
                }
                else if(g.Odabir == "P")
                {
                    protiv++;
                }
                else if (g.Odabir == "S")
                {
                    suzdrzan++;
                }

            }
            Console.WriteLine($"Rezultati glasanja: ZA = {za}, PROTIV = {protiv}, SUZDRŽAN = {suzdrzan}\n");
        }
    }
}
