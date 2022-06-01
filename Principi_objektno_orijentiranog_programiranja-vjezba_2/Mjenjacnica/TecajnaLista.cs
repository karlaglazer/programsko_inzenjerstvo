using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class TecajnaLista
    {
        public List<Tecaj> tecaj;
        public TecajnaLista()
        {
            tecaj = new List<Tecaj>();
            tecaj.Add(new Tecaj("EUR", 7.5));
            tecaj.Add(new Tecaj("AUD", 4.9));
            tecaj.Add(new Tecaj("GBP", 8.9));
        }
    }
}
