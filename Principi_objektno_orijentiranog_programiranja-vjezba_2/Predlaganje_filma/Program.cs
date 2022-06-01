using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predlaganje_filma
{
    internal class Program
    {
        static StreamingServis film = new StreamingServis();
        static void Main(string[] args)
        {
            string izbor = "da";
            while(izbor == "da")
            {
                Console.WriteLine("Zelite li prijedlog filma (da/ne)? ");
                izbor = Console.ReadLine();
                if(izbor == "ne")
                {
                    break;
                }
                Console.WriteLine("Predlazemo sljedeci film: ");
                film.PredloziFilm();
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}
