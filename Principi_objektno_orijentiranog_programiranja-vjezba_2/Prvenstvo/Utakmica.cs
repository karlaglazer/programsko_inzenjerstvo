using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Utakmica
    {
        public Reprezentacija Domacin { get; set; }
        public Reprezentacija Gost { get; set; }
        public int BrojZgoditakaDomacin { get; set; }
        public int BrojZgoditakaGost { get; set; }
        public Utakmica()
        {

        }
        public Utakmica(Reprezentacija domacin, Reprezentacija gost, int goloviD, int goloviG)
        {
            Domacin = domacin;
            Gost = gost;
            BrojZgoditakaDomacin = goloviD;
            BrojZgoditakaGost = goloviG;
        }

        public void GenerirajIspis(Utakmica utakmica)
        {
            Console.WriteLine($"{utakmica.Domacin.Oznaka} {utakmica.BrojZgoditakaDomacin}:{utakmica.BrojZgoditakaGost} {utakmica.Gost.Oznaka}");
        }
    }
}
