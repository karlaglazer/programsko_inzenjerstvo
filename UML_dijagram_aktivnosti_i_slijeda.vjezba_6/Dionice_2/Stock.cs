using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dionice_2
{
    internal class Stock
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public double Worth { get; set; }

        public Stock(string name, int amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Worth = price*amount;
        }

    }
}
