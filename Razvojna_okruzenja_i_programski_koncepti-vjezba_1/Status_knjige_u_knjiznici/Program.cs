using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status_knjige_u_knjižnici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] knjiznica = new string[]
            {
                "Prstenova druzina;Dostupna",
                "Dvije kule;Dostupna",
                "Povratak kralja;Na posudbi",
                "Rat i mir;Dostupna",
                "Zlocin i kazna;Na posudbi",
                "Jadnici;Dostupna"
            };
            string izbor= null;
            do
            {
                Console.WriteLine("Unesite naredbu: ");
                string unos = Console.ReadLine();
                string[] polje = unos.Split(' ');
                izbor = polje[0];
                string nazivKnjige =string.Join(" ", polje.Skip(1));
                if (izbor == "#status")
                {
                    int postoji = 0;
                    foreach (string s in knjiznica)
                    {
                        string[] poljeKnjiga = s.Split(';');
                        if (poljeKnjiga[0] == nazivKnjige)
                        {
                            postoji++;
                            if (poljeKnjiga[1] == "Dostupna")
                            {
                                Console.WriteLine($"Knjiga {nazivKnjige} je dostupna za posudbu!");
                            }
                            else
                            {
                                Console.WriteLine($"Knjiga {nazivKnjige} je vec posuđena!");
                            }
                        }
                    }
                    if (postoji == 0)
                    {
                        Console.WriteLine($"U vašoj knjižnici ne postoji knjiga {nazivKnjige}!");
                    }
                }

            } while (izbor != "#exit");
        }
    }
}
