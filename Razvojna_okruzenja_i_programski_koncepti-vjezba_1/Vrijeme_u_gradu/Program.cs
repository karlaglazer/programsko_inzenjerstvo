using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrijeme_u_gradu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] imeGrada = new string[]
            {
                "Santiago", "Salvador", "London",
                "Zagreb", "Damask", "Istanbul"
            };
            string[] vremenskaZona = new string[]
            {
                "UTC-4", "UTC-3", "UTC+0",
                "UTC+1", "UTC+2", "UTC+3"
            };

            Console.WriteLine("Unesite naziv grada:");
            string nazivGrada = Console.ReadLine();
            int trenutnoSati = DateTime.UtcNow.Hour;
            int trenutnoMinuta = DateTime.UtcNow.Minute;
            for(int i = 0; i<imeGrada.Length; i++)
            {
                if(imeGrada[i] == nazivGrada)
                {
                    int zona = int.Parse(vremenskaZona[i].Substring(3));
                    int vrijemeUGradu = trenutnoSati + zona;
                    Console.WriteLine($"Trenutno vrijeme u gradu {nazivGrada} je: {vrijemeUGradu}:{trenutnoMinuta}");
                }
            }
            Console.ReadLine();
        }
    }
}
