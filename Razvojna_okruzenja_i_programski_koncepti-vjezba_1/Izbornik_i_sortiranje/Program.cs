using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbornik_i_sortiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaGradova = new List<string>();
            int odabir=0;
            while (odabir != 4)
            {
                Console.WriteLine("Odaberite: ");
                Console.WriteLine("1 unos podataka");
                Console.WriteLine("2 sortiranje");
                Console.WriteLine("3 ispis");
                Console.WriteLine("4 izlaz");
                odabir = int.Parse(Console.ReadLine());
                switch (odabir)
                {
                    case 1:
                        Console.WriteLine("Unesite naziv grada");
                        string unos=Console.ReadLine();
                        char.ToUpper(unos[0]);
                        listaGradova.Add(unos);
                        break; 
                    case 2:
                        Console.WriteLine("1 sortiranje uzlazno");
                        Console.WriteLine("2 sortiranje silazno");
                        int sortiranje = int.Parse(Console.ReadLine());
                        switch (sortiranje)
                        {
                            case 1:
                                listaGradova.Sort();
                                break;
                            case 2:
                                listaGradova.Sort();
                                listaGradova.Reverse();
                                break;
                        }
                        break;
                    case 3:
                        foreach (string i in listaGradova)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                }
            }  
            Console.ReadLine();
        }
    }
}
