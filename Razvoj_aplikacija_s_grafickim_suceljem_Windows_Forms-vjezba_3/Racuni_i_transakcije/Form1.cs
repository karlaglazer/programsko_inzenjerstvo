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

namespace Računi_i_transakcije
{
    public partial class FormBanka : Form
    {
        public FormBanka()
        {
            InitializeComponent();
        }

        private void FormBanka_Load(object sender, EventArgs e)
        {
            List<Racun> listaRacuna = Banka.DohvatiPopisRacuna().ToList();
            dataGridViewPopis.DataSource = listaRacuna;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            Racun odabraniRacun =dataGridViewPopis.CurrentRow.DataBoundItem as Racun;
            FormTransakcije formTransakcije = new FormTransakcije(odabraniRacun);
            formTransakcije.ShowDialog();
        }
    }
}
