using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricuva
{
    internal class NestambenaZona : Zona
    {
        public override double IzracunajPricuvu()
        {
            double povrsina = 0;
            foreach (Prostor prostor in ListaProstora)
            {
                povrsina+=prostor.Povrsina;
            }
            return povrsina * 3;
        }
    }
}
