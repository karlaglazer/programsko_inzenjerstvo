using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Knjiznica
    {
        public List<Knjiga> Knjige;
        public List<Posudba> Posudbe;
        public Knjiznica()
        {
            Knjige = new List<Knjiga>();
            Knjige.Add(new Knjiga("1111", "Prstenova druzina"));
            Knjige.Add(new Knjiga("2222", "Dvije kule"));
            Knjige.Add(new Knjiga("3333", "Povratak kralja"));
        }
        public List<Posudba> PosudiKnjigu(string osoba, string isbn)
        {
            Posudbe = new List<Posudba>();
            Knjiga knjiga = null;
            foreach(Knjiga k in Knjige)
            {
                if(k.ISBN == isbn)
                {
                    knjiga = k;
                }
            }
            Posudbe.Add(new Posudba(osoba, knjiga));
            return Posudbe;
        }
    }
}
