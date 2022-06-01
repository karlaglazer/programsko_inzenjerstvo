using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_1
{
    internal class Knjiznica
    {
        private List<Knjiga> knjige;
        public Knjiznica()
        {
            knjige = new List<Knjiga>();
            knjige.Add(new Knjiga("1111", "Prstenova druzina", StatusKnjige.Dostupno));
            knjige.Add(new Knjiga("2222", "Dvije kule", StatusKnjige.Dostupno));
            knjige.Add(new Knjiga("3333", "Povratak kralja", StatusKnjige.Dostupno));
        }
        public Knjiga DohvatiKnjigu(string isbn)
        {
            Knjiga knjiga = null;
            foreach(Knjiga k in knjige)
            {
                if(k.ISBN == isbn)
                {
                    knjiga = k;
                }
            }
            return knjiga;
        }
        public void Posudi(string isbn)
        {
            Knjiga knjiga = DohvatiKnjigu(isbn);
            if(knjiga.Status == StatusKnjige.Dostupno)
            {
                knjiga.Status = StatusKnjige.NaPosudbi;
            }
        }
    }
}
