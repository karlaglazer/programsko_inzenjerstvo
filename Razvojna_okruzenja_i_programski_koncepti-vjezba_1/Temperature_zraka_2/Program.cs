using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_zraka_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meteoStanica = "13,2;C|286,85;K|-|14,8;C|15,1;C|287,95;K|14,2;C|13,7;C";
            string[] polje = meteoStanica.Split('|');
            int broj = 1;
            Console.WriteLine("U proteklih 24 sata su izmjerene sljedeće temperature:");
            foreach (string poljeStr in polje)
            {
                if (poljeStr == "-")
                {
                    Console.WriteLine($"{broj}. ocitanje = Nije uspjelo!");
                }
                else
                {
                    string[] oznaka = poljeStr.Split(';');
                    if (oznaka[1] == "C")
                    {
                        Console.WriteLine($"{broj}. ocitanje = {oznaka[0]} C");
                    }
                    else if (oznaka[1] == "K")
                    {

                        double celzijus = double.Parse(oznaka[0].Replace(',', '.')) - 273.15;
                        Console.WriteLine($"{broj}. ocitanje = {celzijus} C");
                    }
                }

                broj++;
            }
            Console.ReadLine();
                       
        }
    }
}
