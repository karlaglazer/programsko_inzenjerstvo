using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Mjenjacnica
    {
        static TecajnaLista tLista = new TecajnaLista();
        static Konverter konverter = new Konverter();

        public Mjenjacnica()
        {

        }
        public Potvrda PromijeniNovac(double iznos, string valuta)
        {
            double tecaj = 0;
            foreach(Tecaj t in tLista.tecaj)
            {
                if(t.Valuta == valuta)
                {
                    tecaj = t.Tecajv;
                }
            }

            Potvrda potvrda = new Potvrda(iznos, tecaj, konverter.Konvertiraj(iznos, tecaj));
            return potvrda;
        }
        public void IspisPotvrde(Potvrda potvrda, string valuta)
        {
            Console.WriteLine($"Datum: {potvrda.Datum}");
            Console.WriteLine($"Iznos za promjenu: {potvrda.Iznos}");
            Console.WriteLine($"Po tečaju: {potvrda.Tecaj}");
            Console.WriteLine($"Iznosi: {potvrda.Preracunato} {valuta}");
            Console.WriteLine($"Naknada: 5% ({potvrda.Naknada} {valuta})");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Za isplatiti: {potvrda.Isplata} {valuta}");
        }
    }
}
