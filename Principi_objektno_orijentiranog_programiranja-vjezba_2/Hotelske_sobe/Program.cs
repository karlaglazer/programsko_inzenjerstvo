using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    internal class Program
    {
        static Hotel hotel = new Hotel();
        static void Main(string[] args)
        {
            string naredba = "da";
            List<Soba> sobe = new List<Soba>();
            while (naredba != "#exit")
            {
                Console.WriteLine("Unesite naredbu: ");
                string unos = Console.ReadLine();
                string[] polje = unos.Split(' ');
                naredba = polje[0];
                string odabir = "1";
                if (naredba != "#exit")
                {
                    odabir = polje[1];
                }
                if (naredba == "#pronadji")
                {
                    int kapacitet = int.Parse(odabir);
                    sobe = hotel.PronadjiSobe(kapacitet);
                    foreach (Soba soba in sobe)
                    {
                        Console.WriteLine($"Oznaka: {soba.Oznaka}, Kapacitet: {soba.Kapacitet}");
                    }
                    
                }
                else if (naredba == "#rezerviraj")
                {
                    hotel.RezervirajSobu(odabir);
                }
                sobe.Clear();

            }
        }
    }
}
