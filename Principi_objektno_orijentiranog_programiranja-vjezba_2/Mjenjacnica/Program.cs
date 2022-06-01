using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Program
    {
        static Mjenjacnica mj = new Mjenjacnica();
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite iznos u HRK: ");
            double iznos = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite valutu (EUR): ");
            string valuta = Console.ReadLine();
            Potvrda potvrda = mj.PromijeniNovac(iznos, valuta);
            Console.WriteLine("----MJENJACNICA------");
            mj.IspisPotvrde(potvrda,valuta);
            Console.ReadLine();
        }
    }
}
