using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija_valuta
{
    internal class Currency
    {
        public string Name { get; set; }
        public double ExchangeRate { get; set; }

        public double ConvertTo(Currency currency2, double amount)
        {
            double convertedAmount = amount * this.ExchangeRate/currency2.ExchangeRate;
            return convertedAmount;

        }
    }
}
