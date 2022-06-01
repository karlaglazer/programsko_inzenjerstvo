using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonetska_abeceda_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] izrazAbecede = new string[] {
                "Alfa", "Bravo", "Charlie", "Delta",
                "Echo", "Foxtrot", "Golf", "Hotel",
                "India", "Juliett", "Kilo", "Lima",
                "Mike", "November", "Oscar", "Papa",
                "Quebec", "Romeo", "Sierra", "Tango",
                "Uniform", "Victor", "Whiskey", "Xray",
                "Yankee", "Zulu"
            };

            char[] slovo = new char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F',
                'G', 'H', 'I', 'J', 'K', 'L',
                'M', 'N', 'O', 'P', 'Q', 'R',
                'S', 'T', 'U', 'V', 'W', 'X',
                'Y', 'Z'

            };

            Console.WriteLine("Unesite riječ koristeći fonetsku abecedu: ");
            string unos = Console.ReadLine();
            string[] polje = unos.Split(' ');
            int izbaci = 0;
            foreach (string c in polje)
            {
                char[] poljeSlova = c.ToCharArray();
                char slovoR = poljeSlova[0];
                for (int i = 0; i < slovo.Length; i++)
                {
                    if (slovoR == slovo[i])
                    {
                        if (izrazAbecede[i] != c)
                        {
                            Console.WriteLine("Krivo ste unijeli riječ!");
                            izbaci = 1;
                            break;
                        }
                    }
                }
            }
            if (izbaci == 0)
            {
                Console.Write("Napisali ste '");
                foreach (string c in polje)
                {
                    char[] poljeSlova = c.ToCharArray();
                    char slovoR = poljeSlova[0];
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        if (slovoR == slovo[i])
                        {
                            if (izrazAbecede[i] == c)
                            {
                                Console.Write(slovoR);
                            }
                        }
                    }
                }
                Console.Write("' !");
            }

            Console.ReadLine();
        }
    }
}
