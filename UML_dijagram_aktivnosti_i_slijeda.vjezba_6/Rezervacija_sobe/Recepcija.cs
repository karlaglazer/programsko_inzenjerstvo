using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervacija_sobe
{
    internal class Recepcija
    {
        public List<Rezervacija> ListaRezervacija= new List<Rezervacija>();
        private Hotel hotel = new Hotel();
        public List<HotelskaSoba> DohvatiSlobodneSobe(DateTime datum)
        {
            List<HotelskaSoba> listaSlobodnihSoba= hotel.DohvatiSveSobe();
            foreach (var soba in listaSlobodnihSoba)
            {
                    foreach (var rezervacija in ListaRezervacija)
                    {
                        if(soba == rezervacija.HotelskaSoba)
                        {
                            if (datum.Date == rezervacija.DatumRezervacije.Date)
                            {
                                listaSlobodnihSoba.Remove(soba);
                            }
                        }

                    }
                
            }
            return listaSlobodnihSoba;
        }

        public void RezervirajSobu(HotelskaSoba soba, DateTime datum)
        {
            Rezervacija novaRezervacija = new Rezervacija(soba, datum);
            DodajNovuRezervaciju(novaRezervacija);
        }

        private void DodajNovuRezervaciju(Rezervacija novaRezervacija)
        {
            ListaRezervacija.Add(novaRezervacija);
            System.Windows.Forms.MessageBox.Show("Rezervirano");
        }
    }
}
