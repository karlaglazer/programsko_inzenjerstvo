using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija_valuta
{
    internal class CurrencyFactory
    {
        public List<Currency> listaValuta = new List<Currency> 
        {   new Currency{Name = "HRK", ExchangeRate =1},
            new Currency{Name = "EUR", ExchangeRate = 7.4 },
            new Currency{Name ="USD", ExchangeRate = 6.5},
            new Currency{Name ="GBP", ExchangeRate = 8.5},
            new Currency{Name = "CAD", ExchangeRate=4.9}
        };

        public Currency GetCurrency(string currName)
        {
            Currency currency = null;
            foreach(Currency cur in listaValuta)
            {
                if(cur.Name == currName)
                {
                    currency = cur;
                }
            }
            return currency;
        }

    }
}
