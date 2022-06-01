using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());
            double rezultat = 1;
            double rez = 1;
            if (y >= 0)
            {
                for (int i = 0; i < y; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write($"*{x}");
                    }
                    rezultat *= x;
                }
                Console.Write($"={rezultat}");
                Console.ReadLine();
            }
            else
            {
                float broj = 1 / x;
                
                for (int i = 0; i > y; i--)
                {

                    if (i == 0)
                    {
                        
                        Console.Write(broj);
                    }
                    else
                    {
                        Console.Write($"*{broj}");
                    }
                    rez *= x;
                    rezultat = 1 / rez;
                }
                Console.Write($"={rezultat}");
                Console.ReadLine();
            }
        }
    }
}
