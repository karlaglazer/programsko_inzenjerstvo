using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine
{
    internal interface IProstor
    {
        string OznakaProstora { get; set; }
        Kat Kat { get; set; }
        bool Slobodan { get; set; }
        void Prodaj(string kupac);
    }
}
