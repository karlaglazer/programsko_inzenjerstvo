using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dionice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StockPortfolio stockPortfolio = new StockPortfolio();
            List<Stock> stocks = stockPortfolio.GetMyStocks();

            DisplayData(stocks);
        }

        private void DisplayData(List<Stock> stocks)
        {
            dgvStocks.DataSource = stocks;
            double total = 0;
            foreach (Stock stock in stocks)
            {
                total += stock.Worth;
            }
            txtTotal.Text = total.ToString();
        }
    }
}
