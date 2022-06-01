using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novčana_naknada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] podaci = new string[]
            {
                "Ivan Ivic;8NS", "Ivan Ivic;6DS", "Ivan Ivic;4DS",
                "Ivan Ivic;4P", "Pero Peric;3NS", "Pero Peric;5DS",
                "Pero Peric;7DS", "Pero Peric;4DS", "Pero Peric;3P"
            };

            Console.WriteLine("Unesite ime zaposlenika: ");
            string zaposlenik = Console.ReadLine();
            double placa = 0;
            foreach(string s in podaci)
            {
                string[] smjene = s.Split(';');
                if (smjene[0] == zaposlenik)
                {
                    int sati = int.Parse(smjene[1].Substring(0,1));
                    if (smjene[1].Substring(1,1) == "D")
                    {
                        double dnevnica = sati*150;
                        placa += dnevnica;
                    }
                    else if(smjene[1].Substring(1,1) == "N")
                    {
                        double dnevnica=sati*150*1.5;
                        placa +=dnevnica;
                    }
                    else if(smjene[1].Substring(1,1) == "P")
                    {
                        double dnevnica = sati * 150 * 2;
                        placa += dnevnica;
                    }
                }
            }
            Console.WriteLine($"Zaposleniku {zaposlenik} treba isplatiti ukupno {placa} kuna!");
            Console.ReadLine();
        }
    }
}
