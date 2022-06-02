using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatform1
{
    internal class Serija : VideoSadrzaj
    {
        public List<Sezona> ListaSezona { get; set; }
        public Serija(string naziv, string opis)
            : base(naziv, opis)
        {

        }
        public override string VratiInfo()
        {
            string podaci = $"Broj sezona: {ListaSezona.Count}\r\n";
            foreach (Sezona sezona in ListaSezona)
            {
                podaci += $"Broj sezone: {sezona.BrojSezone} Broj epizoda: {sezona.ListaEpizoda.Count}\r\n";
            }
            return podaci;
        }
    }
}
