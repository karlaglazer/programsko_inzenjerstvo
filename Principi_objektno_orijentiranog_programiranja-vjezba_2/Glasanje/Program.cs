using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class Program
    {
        static GlasackaKutija gKutija = new GlasackaKutija();
        static void Main(string[] args)
        {
            Console.WriteLine("APLIKACIJA ZA GLASANJE");
            while (true)
            {

                Console.WriteLine("----------------------");
                Console.WriteLine("Unesite OIB: ");
                string oib = Console.ReadLine();
                Console.WriteLine("Unesite odabir [Z] = Za, [P] = Protiv, [S] = Suzdrzan: ");
                string glas =Console.ReadLine();
                gKutija.Glasaj(oib, glas);
                gKutija.DohvatiRezultateGlasanja();
            }

        }
    }
}
