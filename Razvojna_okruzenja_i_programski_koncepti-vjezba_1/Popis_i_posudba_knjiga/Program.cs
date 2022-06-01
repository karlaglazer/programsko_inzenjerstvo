using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popis_i_posudba_knjiga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos = "da";
            List<string> dostupne = new List<string>();
            List<string> posudene = new List<string>();
            dostupne.Add("Prstenova druzina");
            dostupne.Add("Dvije kule");
            dostupne.Add("Rat i mir");
            dostupne.Add("Jadnici");
            posudene.Add("Povratak kralja");
            posudene.Add("Zlocin i kazna");
            do
            {
                Console.WriteLine("Unesite naredbu: ");
                unos=Console.ReadLine();
                string[] naredba = unos.Split(' ');
                string odabir = naredba[0];
                string knjiga = string.Join(" ", naredba.Skip(1));
                switch (odabir)
                {
                    case "#popis":
                        foreach (string s in dostupne)
                        {
                            Console.WriteLine($"Naziv: {s}, Status:(dostupna)");
                        }
                        foreach (string s in posudene)
                        {
                            Console.WriteLine($"Naziv: {s}, Status:(nedostupna)");
                        }
                        break;
                    case "#posudi":
                        foreach(string s in dostupne)
                        {
                            if(knjiga == s)
                            {
                                posudene.Add(knjiga);
                                dostupne.Remove(knjiga);
                                Console.WriteLine($"Knjiga {knjiga} uspjesno posudena!");
                                break;
                            }
                            
                        }
                        break;
                }

            }
            while (unos!="#exit");
        }
    }
}
