using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometne_utakmice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rezultati = new string[7]
            {
                "HRV 2:0 NIG", "HRV 3:0 ARG", "HRV 2:1 ISL",
                "HRV 1:1 DAN", "HRV 2:2 RUS", "HRV 2:1 ENG",
                "HRV 2:4 FRA"
            };
            int pobjeda=0, poraz =0, remi = 0;
            
            foreach (string s in rezultati)
            {
                string[] polje = s.Split(' ');
                string[] rezultat = polje[1].Split(':');
                int hrvatska=int.Parse(rezultat[0]);
                int ostali = int.Parse(rezultat[1]);
                if (hrvatska > ostali)
                {
                    pobjeda++;
                }
                else if(hrvatska < ostali)
                {
                    poraz++;
                }
                else
                {
                    remi++;
                }
            }
            Console.WriteLine("TABLICA REZULTATA");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Ukupno ostvarenih pobjeda: {pobjeda}");
            Console.WriteLine($"Ukupno ostvarenih poraza: {poraz}");
            Console.WriteLine($"Ukupno ostvarenih remija: {remi}");
            Console.ReadLine();
        }
    }
}
