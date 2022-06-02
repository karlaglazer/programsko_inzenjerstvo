using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricuva
{
    internal class Upravitelj
    {
        public List<Zgrada> ListaZgrada { get; set; }
        public double IzracunajBudzet(Zgrada zgrada)
        {
            double zbroj = 0;
            foreach(Zgrada z in ListaZgrada)
            {
                foreach (Zona zona in z.listaZona)
                {
                    zbroj+=zona.IzracunajPricuvu();
                }
            }
            return zbroj;
        }
    }
}
