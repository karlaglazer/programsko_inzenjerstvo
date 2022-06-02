using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace Provedba_i_sortiranje_transakcija
{
    public partial class FormProvedi : Form
    {
        public FormProvedi()
        {
            InitializeComponent();
        }

        private void FormProvedi_Load(object sender, EventArgs e)
        {
            List<Racun> popisRacuna1 = Banka.DohvatiPopisRacuna().ToList();
            List<Racun> popisRacuna2 = Banka.DohvatiPopisRacuna().ToList();
            comboPlatitelj.DataSource = popisRacuna1;
            comboPrimatelj.DataSource = popisRacuna2;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProvedi_Click(object sender, EventArgs e)
        {
            Racun platitelj = comboPlatitelj.SelectedItem as Racun;
            Racun primatelj = comboPrimatelj.SelectedItem as Racun;
            double iznos = double.Parse(txtIznos.Text);
            Banka.ProvediTransakciju(platitelj, primatelj, iznos);
            this.Close();
        }
    }
}
