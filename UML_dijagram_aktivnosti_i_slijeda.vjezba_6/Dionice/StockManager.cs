using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StocksLib;

namespace Dionice
{
    internal class StockManager
    {
        public List<Stock> GetStocks()
        {
            List<string> stocksData = StockExchangeAPI.GetStocksData();
            List<Stock> stocks = new List<Stock>();
            foreach (string stock in stocksData)
            {
                stocks.Add(StockParser.ParseStock(stock));
            }
            return stocks;
        }
    }
}
