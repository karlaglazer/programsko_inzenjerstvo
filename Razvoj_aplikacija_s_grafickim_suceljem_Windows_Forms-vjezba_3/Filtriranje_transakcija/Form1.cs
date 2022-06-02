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

namespace Filtriranje_transakcija
{
    public partial class FormPopisTransakcija : Form
    {
        public FormPopisTransakcija()
        {
            InitializeComponent();
        }

        private void FormPopisTransakcija_Load(object sender, EventArgs e)
        {
            Ocisti();

        }
        private void Ocisti()
        {
            List<Racun> listaRacuna = Banka.DohvatiPopisRacuna().ToList();
            List<Transakcija> listaTransakcija = new List<Transakcija>();
            foreach (Racun racun in listaRacuna)
            {
                List<Transakcija> listal = racun.DohvatiTransakcije().ToList();
                listaTransakcija.AddRange(listal);
            }
            dataGridTransakcije.DataSource = listaTransakcija;
            comboBRacun.DataSource = Banka.DohvatiPopisRacuna();
            comboBRacun.SelectedItem = null;
            radioBtnSve.Checked = true;
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            Ocisti();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Racun odabraniRacun = Banka.DohvatiRacun(comboBRacun.SelectedItem.ToString());
            if (radioBtnSve.Checked)
            {
                dataGridTransakcije.DataSource = odabraniRacun.DohvatiTransakcije();
            }
            else if (radioBtnIsplate.Checked)
            {
                dataGridTransakcije.DataSource = odabraniRacun.DohvatiIsplate();
            }
            else if (radioBtnUplate.Checked)
            {
                dataGridTransakcije.DataSource = odabraniRacun.DohvatiUplate();
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Racun racun = dataGridTransakcije.CurrentCell.Value as Racun;
            FormaDetaljiRacuna formaDetaljiRacuna = new FormaDetaljiRacuna(racun);
            this.Hide();
            formaDetaljiRacuna.Show();
        }
    }
}
