using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dionice
{
    internal static class StockParser
    {
        public static Stock ParseStock(string item)
        {
            string[] polje = item.Split(';');
            string name = polje[0];
            double currentPrice = double.Parse(polje[1].Replace(',', '.'));
            double previousPrice = double.Parse(polje[2].Replace(',', '.'));
            return new Stock(name, currentPrice, previousPrice);
        }
    }
}
