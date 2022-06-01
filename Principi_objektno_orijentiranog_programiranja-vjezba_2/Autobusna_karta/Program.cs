using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobusna_karta
{
    internal class Program 
    {
        static AutobusniKolodvor autobusniKolodvor = new AutobusniKolodvor();
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite polaziste, odrediste i tip karte:");
            string unos = Console.ReadLine();
            string[] polje = unos.Split(' ');

            autobusniKolodvor.KupiKartu(polje[0], polje[1], polje[2]);

            Console.ReadLine();
        }
    }
}
