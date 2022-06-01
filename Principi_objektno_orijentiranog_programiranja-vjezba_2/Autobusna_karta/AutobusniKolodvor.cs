using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobusna_karta
{
    internal class AutobusniKolodvor 
    {
        private List<Linija> linije;
        public AutobusniKolodvor()
        {
            InicijalizirajListu();
           
        }
        private void InicijalizirajListu()
        {
            linije = new List<Linija>();

            linije.Add(new Linija("Varaždin", "Zagreb", 80));
            linije.Add(new Linija("Varaždin", "Cakovec", 20));
            linije.Add(new Linija("Varaždin", "Slavonski Brod", 240));
            linije.Add(new Linija("Varaždin", "Krapina", 40));
            linije.Add(new Linija("Varaždin", "Novi Marof", 22));
            linije.Add(new Linija("Varaždin", "Koprivnica", 45));
            linije.Add(new Linija("Varaždin", "Virovitica", 100));
            linije.Add(new Linija("Varaždin", "Osijek", 220));
        }

        private static double IzracunajCijenu (int udaljenost, string tipKarte)
        {
            double cijena=udaljenost;
            if(tipKarte == "Regularna")
            {
                cijena *= 1.5;
            }
            else if(tipKarte == "Studentska")
            {
                cijena *= 1.2;
            }
            else if (tipKarte == "Povratna")
            {
                cijena *= 2;
            }
            return cijena;
        }

        public void KupiKartu(string polaziste, string odrediste, string tipKarte)
        {
            int udaljenost = 0;
            foreach(Linija l in linije)
            {
                    if (odrediste == l.Odrediste)
                    {
                        udaljenost = l.Udaljenost;
                    }
               
            }
            double cijenaKarte = IzracunajCijenu(udaljenost, tipKarte);
            Console.WriteLine($"Cijena za kartu tipa {tipKarte}, na relaciji {polaziste}-{odrediste} iznosi {cijenaKarte} kn!");
        }
            

    }
}
