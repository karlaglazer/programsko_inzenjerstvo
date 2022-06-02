using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatform2Lib
{
    internal class Serija : IVideoZapis
    {
        public string Naziv { get ; set ; }
        public string Opis { get ; set ; }
        public KategorijaZapisa Kategorija { get ; set ; }
        public List<Sezona> ListaSezona { get; set; }

        public Serija(string naziv, string opis)
        {
            Naziv = naziv;
            Opis = opis;
            Kategorija = KategorijaZapisa.Serija;
        }
        public string Reproduciraj()
        {
            return $"Započeta reprodukcija serije {this.Naziv}, sezone {ListaSezona[0].RedniBroj}, epizoda {ListaSezona[0].ListaEpizoda[0].Naziv}";
        }
    }
}
