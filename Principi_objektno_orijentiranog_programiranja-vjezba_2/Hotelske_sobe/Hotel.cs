using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    internal class Hotel
    {
        private List<Soba> soba;
        public Hotel()
        {
            soba = new List<Soba>();
            soba.Add(new Soba("10A", 3, StatusSobe.Slobodna));
            soba.Add(new Soba("10B", 1, StatusSobe.Rezervirana));
            soba.Add(new Soba("11A", 2, StatusSobe.Slobodna));
            soba.Add(new Soba("11B", 4, StatusSobe.Slobodna));
            soba.Add(new Soba("12A", 5, StatusSobe.Slobodna));
            soba.Add(new Soba("12B", 3, StatusSobe.Rezervirana));
            soba.Add(new Soba("13A", 1, StatusSobe.Slobodna));
            soba.Add(new Soba("13B", 2, StatusSobe.Rezervirana));
        }
        public List<Soba> PronadjiSobe(int brojOsoba)
        {
            List<Soba> slobodne = new List<Soba>();
            foreach(Soba s in soba)
            {
                if (s.Status == StatusSobe.Slobodna)
                {
                    if (s.Kapacitet >= brojOsoba)
                    {
                        slobodne.Add(s);
                    }
                }
            }
            return slobodne;
        }
        public void RezervirajSobu(string oznaka)
        {
            foreach(Soba s in soba)
            {
                if (s.Oznaka == oznaka)
                {
                    if (s.Status == StatusSobe.Slobodna)
                    {
                        s.Status=StatusSobe.Rezervirana;
                    }
                }
            }
        }
    }
}
