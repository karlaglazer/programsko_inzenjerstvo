using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometne_utakmice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rezultati = new string[6]
            {
                "ARG 1:1 ISL", "HRV 2:0 NIG", "ARG 0:3 HRV",
                "NIG 2:0 ISL", "NIG 1:2 ARG", "ISL 1:2 HRV"
            };
            Console.WriteLine("TABLICA REZULTATA");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Unesite oznaku reprezentacije: ");
            string oznaka=Console.ReadLine();
            Console.WriteLine($"Utakmice reprezentacije: {oznaka}");

            foreach (string s in rezultati)
            {
                string[] reprezentacija = s.Split(' ');
                if (reprezentacija[0] == oznaka)
                {
                    Console.WriteLine(s);
                }
                else if (reprezentacija[2]==oznaka)
                {
                    string[] rezultat = reprezentacija[1].Split(':');
                    Console.WriteLine($"{reprezentacija[2]} {rezultat[1]}:{rezultat[0]} {reprezentacija[0]}");
                }
            }
            Console.ReadLine();
        }
    }
}
