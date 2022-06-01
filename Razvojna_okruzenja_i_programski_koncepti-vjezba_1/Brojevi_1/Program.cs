using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brojevi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj jedinica: ");
            int jedinice = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite broj desetica: ");
            int desetice = int.Parse(Console.ReadLine())*10;
            double rezultat = (jedinice + desetice) * 2.1;
            Console.WriteLine($"Rezultat: {rezultat}");
            Console.ReadLine();
        }
    }
}
