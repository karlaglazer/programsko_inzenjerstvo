using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori_1
{
    internal class Program
    {
        static MeteoStanica meteo = new MeteoStanica();
        static void Main(string[] args)
        {
            Console.WriteLine("U kojoj mjernoj jedinici želite izracun prosjecne temperature (C/K)?");
            string jedinica = Console.ReadLine();
            if(jedinica == "C")
            {
                Console.WriteLine($"Prosjecna temperatura je: {meteo.DohvatiProsjecnuTemperaturu(JedinicaMjere.Celzius)} Celzius");
            }
            else if(jedinica == "K")
            {
                Console.WriteLine($"Prosjecna temperatura je: {meteo.DohvatiProsjecnuTemperaturu(JedinicaMjere.Kelvin)} Kelvin");
            }
            else
            {
                Console.WriteLine("Krivo");
            }
            Console.ReadLine();
        }
    }
}
