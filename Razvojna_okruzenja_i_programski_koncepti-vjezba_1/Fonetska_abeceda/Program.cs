using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonetska_abeceda
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

            Console.WriteLine("Unesite riječ: ");
            string rijec = Console.ReadLine();
            char[] slovaR = rijec.ToCharArray();
            Console.Write("Rijec ispisana fonetskom abecedom: ");
            foreach (char c in slovaR)
            {
                for (int i = 0; i< slovo.Length; i++)
                {
                    if(slovo[i] == c)
                    {
                        Console.Write($"{izrazAbecede[i]} ");
                    }
                }
            }
            Console.WriteLine();
                

            Console.ReadLine();
        }
    }
}
