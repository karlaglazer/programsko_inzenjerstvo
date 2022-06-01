using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Godina: ");
            int godinaRodenja = int.Parse(Console.ReadLine());
            Console.Write("Mjesec: ");
            int mjesecRodenja = int.Parse(Console.ReadLine());
            int trenutnaGodina = DateTime.Now.Year;
            int trenutniMjesec = DateTime.Now.Month;
            int godine = trenutnaGodina - godinaRodenja;
            int mjesec;
            if (trenutniMjesec > mjesecRodenja)
            {
                mjesec = trenutniMjesec - mjesecRodenja;
            }
            else
            {
                godine--;

                    mjesec = (12 - mjesecRodenja) + trenutniMjesec;

            }
            int starost = (godine * 12 + mjesec);
            Console.WriteLine($"{starost} mjeseci \n{starost*30} dana");
            Console.ReadLine();
        }
    }
}
