using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigurnosna_vrata
{
    public partial class Otvaranje : Form
    {
        public Otvaranje()
        {
            InitializeComponent();
        }

        private void btn501_Click(object sender, EventArgs e)
        {
            int brKartice = int.Parse(txtBrojKartice.Text.ToString());
            int pin = int.Parse(txtPIN.Text.ToString());
            int brVrata = 501;
            OtvaranjeVrata(brKartice, pin, brVrata);
        }

        private void btn502_Click(object sender, EventArgs e)
        {
            int brKartice = int.Parse(txtBrojKartice.Text.ToString());
            int pin = int.Parse(txtPIN.Text.ToString());
            int brVrata = 502;
            OtvaranjeVrata(brKartice, pin, brVrata);
        }

        private void btn503_Click(object sender, EventArgs e)
        {
            int brKartice = int.Parse(txtBrojKartice.Text.ToString());
            int pin = int.Parse(txtPIN.Text.ToString());
            int brVrata = 503;
            OtvaranjeVrata(brKartice, pin, brVrata);
        }

        private void OtvaranjeVrata(int brKartice, int pin, int brVrata)
        {
            SigurnosnaKontrola sigurnosnaKontrola = new SigurnosnaKontrola();
            if (sigurnosnaKontrola.OtvoriVrata(brKartice, pin, brVrata) == true)
            {
                MessageBox.Show("Vrata uspješno otvorena!");
            }
            else
            {
                MessageBox.Show("Vrata nisu otvorena!");
            }
        }


    }
}
