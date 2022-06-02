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
    public partial class FormTransakcije : Form
    {
        Racun racun;
        public FormTransakcije(Racun racun1)
        {
            InitializeComponent();
            racun = racun1;
        }

        private void FormTransakcije_Load(object sender, EventArgs e)
        {
            txtIBAN.Text = racun.IBAN.ToString();
            txtStanje.Text = racun.Stanje.ToString();
            txtVlasnik.Text = racun.Vlasnik.ToString();
            radioBtnSve.Checked = true;
            List<Transakcija> listaTransakcija= racun.DohvatiTransakcije();
            dataGridViewRacunTransak.DataSource = listaTransakcija;
        }

        private void btnPrimjeni_Click(object sender, EventArgs e)
        {
            if(radioBtnSve.Checked == true)
            {
                List<Transakcija> listaTransakcija = racun.DohvatiTransakcije();
                dataGridViewRacunTransak.DataSource = listaTransakcija;
            }
            else if(radioBtnIsplate.Checked == true)
            {
                List<Transakcija> listaTransakcija = racun.DohvatiIsplate();
                dataGridViewRacunTransak.DataSource = listaTransakcija;
            }
            else if(radioBtnUplate.Checked == true)
            {
                List<Transakcija> listaTransakcija = racun.DohvatiUplate();
                dataGridViewRacunTransak.DataSource = listaTransakcija;
            }
        }
    }
}
