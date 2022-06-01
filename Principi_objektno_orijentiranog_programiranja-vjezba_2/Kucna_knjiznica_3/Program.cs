using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Program 
    {
        static Knjiznica knjiznica = new Knjiznica();
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime prezime osobe kojoj posudujemo knjigu: ");
            string osoba = Console.ReadLine();
            Console.WriteLine("Unesite ISBN knjige: ");
            string isbn = Console.ReadLine();
            List<Posudba> posudba = new List<Posudba>();
            posudba = knjiznica.PosudiKnjigu(osoba, isbn);
            Console.WriteLine("--------------------");
            Console.WriteLine("------POSUDBA-------");
            Console.WriteLine("--------------------");
            foreach(Posudba p in posudba)
            {
                if (p.PosudjenaKnjiga.ISBN == isbn)
                {
                    Console.WriteLine($"Osoba: {osoba}");
                    Console.WriteLine($"ISBN knjige: {isbn}");
                    Console.WriteLine($"Naslov knjige: {p.PosudjenaKnjiga.Naslov}");
                    Console.WriteLine($"Datum posudbe: {p.Datum}");
                }
            }
            Console.ReadLine();

        }
    }
}
