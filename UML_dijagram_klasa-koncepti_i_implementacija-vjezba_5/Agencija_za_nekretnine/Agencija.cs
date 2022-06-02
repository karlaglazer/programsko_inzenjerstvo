using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine
{
    internal class Agencija
    {
        public string Naziv { get; set; }
        public List<Zgrada> ListaZgrada { get; set; }

        public void ProdajProstor(string oznakaProstora, string kupac)
        {
            foreach(Zgrada zgrada in ListaZgrada)
            {
                foreach (Kat kat in zgrada.ListaKatova)
                {
                    foreach (IProstor prostor in kat.ListaProstora)
                    {
                        if (oznakaProstora == prostor.OznakaProstora)
                        {
                            prostor.Prodaj(kupac);
                        }
                    }

                }
            }
        }
    }
}
