using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervacija_sobe
{
    internal class Hotel
    {
        public List<HotelskaSoba> PopisHotelskihSoba = new List<HotelskaSoba>()
        {   new HotelskaSoba{OznakaSobe = 501, Kapacitet =3},
            new HotelskaSoba{OznakaSobe =502, Kapacitet = 2},
            new HotelskaSoba{OznakaSobe =503, Kapacitet = 5},
            new HotelskaSoba{OznakaSobe =504, Kapacitet = 2}
        };
        public List<HotelskaSoba> DohvatiSveSobe()
        {
            return PopisHotelskihSoba;
        }
    }
}
