using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dionice
{
    internal class Stock
    {
        public string Name { get; set; }
        public double CurrentPrice { get; set; }
        public double PreviousPrice { get; set; }
        public double Difference { get; set; }

        public Stock(string name, double currentPrice, double previousPrice)
        {
            Name = name;
            CurrentPrice = currentPrice;
            PreviousPrice = previousPrice;
            Difference = Math.Round(((CurrentPrice - PreviousPrice) / PreviousPrice) * 100,2);
        }
    }
}
