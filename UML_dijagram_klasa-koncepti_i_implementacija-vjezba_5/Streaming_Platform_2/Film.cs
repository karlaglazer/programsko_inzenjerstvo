using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatform2Lib
{
    internal class Film : IVideoZapis
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public KategorijaZapisa Kategorija { get; set; }
        public int Trajanje { get; set; }
        public Film(string naziv, string opis, int trajanje)
        {
            Naziv = naziv;
            Opis = opis;   
            Trajanje = trajanje;
            Kategorija = KategorijaZapisa.Film;
        }

        public string Reproduciraj()
        {
            return $"Zapoceta reprodukcija filma {this.Naziv}";
        }
    }
}
