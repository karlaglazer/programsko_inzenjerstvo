using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Program
    {
        static Skladiste skladiste = new Skladiste();
        static Proizvod proizvod = new Proizvod();
        static void Main(string[] args)
        {
            string naziv;
            double cijena;
            double kolicina;
            int izbor = 0;
            while (izbor != 5)
            {
                Console.WriteLine("1 dodaj proizvod na skladište");
                Console.WriteLine("2 povećaj količinu proizvoda");
                Console.WriteLine("3 smanji količinu proizvoda");
                Console.WriteLine("4 ispiši stanje skladišta");
                Console.WriteLine("5 izlaz");
                izbor = int.Parse(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        Console.WriteLine("Naziv proizvoda: ");
                        proizvod.Naziv = Console.ReadLine();
                        Console.WriteLine("Cijena: ");
                        proizvod.JedinicnaCijena = double.Parse(Console.ReadLine());
                        Console.WriteLine("Kolicina: ");
                        proizvod.Stanje = double.Parse(Console.ReadLine());
                        skladiste.DodajProizvod(proizvod);
                        break;
                    case 2:
                        Console.WriteLine("Naziv proizvoda: ");
                        proizvod = skladiste.DohvatiProizvod(Console.ReadLine());
                        Console.WriteLine("Kolicina: ");
                        proizvod.DodajNaStanje(double.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Naziv proizvoda: ");
                        proizvod = skladiste.DohvatiProizvod(Console.ReadLine());
                        Console.WriteLine("Kolicina: ");
                        proizvod.OduzmiSaStanja(double.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        skladiste.DohvatiSveProizvode();
                        Console.WriteLine(skladiste.IzracunajUkupnuVrijednostZaliha());
                        break;
                }
            }
        }
    }
}
