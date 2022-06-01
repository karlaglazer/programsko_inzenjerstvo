using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodovi_na_vježbama
{
    internal class Program
    {
        static Evidencija evidencija  = new Evidencija();
        static void Main(string[] args)
        {
            int izbor = 0;
            while (izbor != 4)
            {
                Console.WriteLine("1. Dodavanje studenata");
                Console.WriteLine("2. Dodavanje vježbe i ocjenjivanje studenata");
                Console.WriteLine("3. Ispis bodova");
                Console.WriteLine("4. Izlaz");
                izbor=int.Parse(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        evidencija.DodajStudenta();
                        break;
                    case 2:
                        evidencija.NovaVjezba();
                        break;
                    case 3:
                        evidencija.Ispis();
                        break;
                }
            }
        }
    }
}
