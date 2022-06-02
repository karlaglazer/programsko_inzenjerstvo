using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricuva
{
    internal abstract class Zona
    {
        public string Naziv { get; set; }
        public List<Prostor> ListaProstora { get; set; }
        public abstract double IzracunajPricuvu();
    }
}
