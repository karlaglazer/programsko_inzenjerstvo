using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervacija_sobe
{
    internal class Rezervacija
    {
        public HotelskaSoba HotelskaSoba { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public Rezervacija(HotelskaSoba soba, DateTime datum)
        {
            HotelskaSoba = soba;
            DatumRezervacije = datum;
        }
    }
}
