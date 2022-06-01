using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brojevi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C = ");
            int c = int.Parse(Console.ReadLine());
            int[] dijeljivi=new int[b - a];
            int index=0;
            Console.Write("Rezultat je: ");
            for (int i = a; i <= b; i++)
            {
                if (i%c==0)
                {
                    dijeljivi[index] = i;
                    if (index != 0)
                    {
                        Console.Write(", ");
                    }
                    
                    Console.Write(dijeljivi[index]);
                    
                    index++;
                }
            }
            Console.WriteLine();
            int suma = 0;
            for (int i = 0; i < index; i++)
            {
                suma += dijeljivi[i];
            }
            Console.WriteLine($"Suma je {suma}");

            Console.ReadLine();
        }
    }
}
