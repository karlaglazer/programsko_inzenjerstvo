using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svjetsko_vrijeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vremenskaZona = new string[]
            {
                "Santiago;-4", "Salvador; -3",
                "London;+0", "Zagreb;+1",
                "Damask;+2", "Istanbul;+3"
            };

            int trenutnoSati = DateTime.UtcNow.Hour;
            int trenutnoMinuta = DateTime.UtcNow.Minute;

            foreach (string s in vremenskaZona)
            {
                string[] polje = s.Split(';');
                int razlika = int.Parse(polje[1]);
                int sati = trenutnoSati + razlika;
                Console.WriteLine($"Trenutno vrijeme za {polje[0]} je: {sati}:{trenutnoMinuta}");
            }
            Console.ReadLine();
        }
    }
}
