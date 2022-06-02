using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burza
{
    public class TradingAccount
    {
        public string AccountNo { get; set; }
        private List<Wallet> ListaNovcanika { get; set; }
        public TradingAccount(string accountNo)
        {
            AccountNo = accountNo;
        }
        public double CalculateTotalValue()
        {
            double zbroj = 0;
            foreach(Wallet wallet in ListaNovcanika)
            {
                zbroj += wallet.CalculateValue();
            }
            return zbroj;
        }
    }
}
