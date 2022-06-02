using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StocksLib;

namespace Dionice_2
{
    internal class StockPortfolio
    {
        public List<Stock> GetMyStocks()
        {
            List<string> ownedStocksData = StockExchangeAPI.GetOwnedStocksData();
            List<Stock> stocks = new List<Stock>();
            foreach (var stock in ownedStocksData)
            {
                string[] polje = stock.Split(';');
                string name = polje[0];
                int amount = int.Parse(polje[1]);
                double price = StockExchangeAPI.GetStockPrice(name);
                stocks.Add(new Stock(name, amount, price));
            }
            return stocks;
        }
    }
}
