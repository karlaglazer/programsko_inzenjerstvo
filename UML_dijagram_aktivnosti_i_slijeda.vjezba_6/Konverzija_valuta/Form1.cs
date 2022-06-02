using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konverzija_valuta
{
    public partial class FrmConverter : Form
    {
        private CurrencyFactory currFactory = new CurrencyFactory();
        public FrmConverter()
        {
            InitializeComponent();
            comboBoxCurrency1.Items.AddRange(new string[] {"HRK", "EUR", "USD", "GBP", "CAD"});
            comboBoxCurrency2.Items.AddRange(new string[] { "HRK", "EUR", "USD", "GBP", "CAD" });
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Currency currency1 = currFactory.GetCurrency(comboBoxCurrency1.SelectedItem.ToString());
            Currency currency2 = currFactory.GetCurrency(comboBoxCurrency2.SelectedItem.ToString());
            double amount = double.Parse(txtAmount.Text);
            double convertedAmount = currency1.ConvertTo(currency2, amount);

            ShowResults(convertedAmount);
        }

        private void ShowResults(double convertedAmount)
        {
            txtConverted.Text = convertedAmount.ToString();
        }
    }
}
