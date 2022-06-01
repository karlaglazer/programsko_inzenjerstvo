using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Program
    {
        static Prvenstvo prvenstvo = new Prvenstvo();
        static void Main(string[] args)
        {
            string oznaka;
            string oznakag;
            int bodovid;
            int bodovig;
            string naziv;
            int izbor = 5;
            do
            {
                Console.WriteLine("PRVENSTVO APP");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("[1] Unesi reprezentaciju ");
                Console.WriteLine("[2] Evidentiraj utakmicu");
                Console.WriteLine("[3] Ispiši tablicu rezultata");
                Console.WriteLine("[4] Ispiši bodovnu ljestvicu");
                Console.WriteLine("[0] Izlaz");
                Console.WriteLine("-----------------------------------");
                izbor = int.Parse(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        Console.WriteLine("Unesite oznaku: ");
                        oznaka = Console.ReadLine();
                        Console.WriteLine("Unesite naziv: ");
                        naziv = Console.ReadLine();
                        prvenstvo.UnesiReprezentaciju(oznaka, naziv);
                        break;
                    case 2:
                        Console.WriteLine("Unesite oznaku domacina: ");
                        oznaka = Console.ReadLine();
                        Console.WriteLine("Unesite golove domacina: ");
                        bodovid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite oznaku gosta: ");
                        oznakag = Console.ReadLine();
                        Console.WriteLine("Unesite golove gosta: ");
                        bodovig = int.Parse(Console.ReadLine());
                        prvenstvo.UnesiUtakmicu(oznaka, bodovid, oznakag, bodovig);
                        break;
                    case 3:
                        prvenstvo.GenerirajTablicuRezultata();
                        break;
                    case 4:
                        prvenstvo.GenerirajBodovnuLjestvicu();
                        break;
                }
            } while (izbor != 0);
        }
    }
}
