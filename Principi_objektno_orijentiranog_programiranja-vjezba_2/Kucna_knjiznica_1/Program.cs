using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_1
{
    internal class Program
    {
        static Knjiznica knjiznica = new Knjiznica();
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ISBN knjige koju posudujete: ");
            string isbn = Console.ReadLine();
            knjiznica.Posudi(isbn);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"ISBN: {knjiznica.DohvatiKnjigu(isbn).ISBN}");
            Console.WriteLine($"Naslov: {knjiznica.DohvatiKnjigu(isbn).Naslov}");
            Console.WriteLine($"Naslov: {knjiznica.DohvatiKnjigu(isbn).Status}");
            Console.ReadLine();
        }
    }
}
