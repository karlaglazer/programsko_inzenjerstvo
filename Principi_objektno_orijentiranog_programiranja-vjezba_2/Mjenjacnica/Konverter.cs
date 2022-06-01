using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Konverter
    {
        public Konverter()
        {

        }
        public double Konvertiraj(double hrk, double tecaj)
        {
            double konvertirano = hrk / tecaj;
            return konvertirano;
        }
    }
}
