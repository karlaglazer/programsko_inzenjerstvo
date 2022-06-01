using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite godinu rođenja: ");
            int godinaRodenja = int.Parse(Console.ReadLine());
            int trenutnaGodina = DateTime.Now.Year;
            int starost = trenutnaGodina - godinaRodenja;
            Console.WriteLine($"Imate {starost} godina.");
            int prijestupnaGodina = 0;
            for (int i = godinaRodenja; i < trenutnaGodina; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            prijestupnaGodina++;
                        }
                    }
                    else
                    {
                        prijestupnaGodina++;
                    }
                }
                
                
            }
            Console.WriteLine($"Prijestupna: {prijestupnaGodina}");
            Console.ReadLine();
        }
    }
}
