using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sTAROST_OSOBE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IZRAČUN STAROSTI OSOBE:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Upišite datum rođenja u formatu 'dd mmmm yyyy' (npr. 20 siječanj 1995): ");
            string datumRodjenja = Console.ReadLine();
            string[] polje = datumRodjenja.Split(' ');
            int dan =int.Parse( polje[0]);
            string mjesec = polje[1];
            int godina = int.Parse( polje[2]);
            int brojMjeseca = 0;
            int trenutnaGodina = DateTime.Now.Year;
            int trenutniMjesec = DateTime.Now.Month;
            int trenutniDan = DateTime.Now.Day;
            switch (mjesec)
            {
                case "sijecanj":
                    brojMjeseca = 1;
                    break;
                case "veljaca":
                    brojMjeseca = 2;
                    break;
                case "ozujak":
                    brojMjeseca = 3;
                    break;
                case "travanj":
                    brojMjeseca=4;
                    break;
                case "svibanj":
                    brojMjeseca = 5;
                    break;
                case "lipanj":
                    brojMjeseca = 6;
                    break;
                case "srpanj":
                    brojMjeseca = 7;
                    break;
                case "kolovoz":
                    brojMjeseca = 8;
                    break;
                case "rujan":
                    brojMjeseca = 9;
                    break;
                case "listopad":
                    brojMjeseca = 10;
                    break;
                case "studeni":
                    brojMjeseca = 11;
                    break;
                case "prosinac":
                    brojMjeseca = 12;
                    break;
            }
            int starostGodina = trenutnaGodina - godina;
            if (trenutniMjesec > brojMjeseca)
            {
                Console.WriteLine($"Dana {dan}.{brojMjeseca}.{trenutnaGodina}. godine ste napunili {starostGodina} godina!");
            }
            else if(trenutniMjesec < brojMjeseca)
            {
                Console.WriteLine($"Dana {dan}.{brojMjeseca}.{trenutnaGodina}. godine ćete napuniti {starostGodina} godina!");
            }
            else
            {
                if (trenutniDan > dan)
                {
                    Console.WriteLine($"Dana {dan}.{brojMjeseca}.{trenutnaGodina}. godine ste napunili {starostGodina} godina!");
                }
                else if(trenutniDan < dan)
                {
                    Console.WriteLine($"Dana {dan}.{brojMjeseca}.{trenutnaGodina}. godine ćete napuniti {starostGodina} godina!");
                }
                else
                {
                    Console.WriteLine($"Danas {dan}.{brojMjeseca}.{trenutnaGodina}. godine ste napunili {starostGodina} godina!");
                }
            }
            Console.ReadLine();

        }
    }
}
