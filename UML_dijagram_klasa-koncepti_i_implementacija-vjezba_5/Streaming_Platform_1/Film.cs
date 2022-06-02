using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatform1
{
    internal class Film : VideoSadrzaj
    {
        public int Trajanje { get; set; }
        public Film(string naziv, string opis, int trajanje)
            :base(naziv, opis)
        {
            Trajanje = trajanje;
        }
        public override string VratiInfo()
        {
            return $"Naziv: {this.Naziv} \r\nOpis: {this.Opis} \r\nTrajanje: {this.Trajanje}";
        }
    }
}
