using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Skladiste
    {
        private List<Proizvod> listaProizvoda = new List<Proizvod>();
        public void DodajProizvod(Proizvod proizvod)
        {
            bool postoji = false;
            foreach(Proizvod p in listaProizvoda)
            {
                if(p.Naziv == proizvod.Naziv)
                {
                    postoji = true;
                }
            }
            if (postoji == false)
            {
                listaProizvoda.Add(new Proizvod(proizvod.Naziv, proizvod.JedinicnaCijena, proizvod.Stanje));
            }
        }
        public void UkloniProizvod(Proizvod proizvod)
        {
            foreach (Proizvod p in listaProizvoda)
            {
                if(p.Naziv == proizvod.Naziv)
                {
                    listaProizvoda.Remove(p);
                }
            }
        }
        public Proizvod DohvatiProizvod(string naziv)
        {
            Proizvod proizvod = null;
            foreach(Proizvod p in listaProizvoda)
            {
                if(p.Naziv == naziv)
                {
                    proizvod = p;
                }
            }
            return proizvod;
        }
        public void DohvatiSveProizvode()
        {
            foreach(Proizvod p in listaProizvoda)
            {
                Console.WriteLine($"Naziv: {p.Naziv}, jedinicna cijena: {p.JedinicnaCijena}, stanje: {p.Stanje}, vrijednost: {p.JedinicnaCijena * p.Stanje}");
            }
        }
        public double IzracunajUkupnuVrijednostZaliha()
        {
            double vrijednost = 0;
            foreach(Proizvod p in listaProizvoda)
            {
                double pojedinacno = p.JedinicnaCijena * p.Stanje;
                vrijednost+=pojedinacno;
            }
            return vrijednost;
        }
    }
}
