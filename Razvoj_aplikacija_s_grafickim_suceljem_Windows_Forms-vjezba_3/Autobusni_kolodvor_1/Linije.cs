using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace Autobusni_kolodvor1
{
    public partial class Linije : Form
    {
        KreiranjeKarte kreiranje  = new KreiranjeKarte();

        public Linije()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Linije_Load(object sender, EventArgs e)
        {
            List<Linija> listaLinija = AutobusniKolodvor.DohvatiLinije();
            dataGridViewLinije.DataSource = listaLinija;
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            Linija odabrana = dataGridViewLinije.CurrentRow.DataBoundItem as Linija;
            kreiranje.linija1 = odabrana;
            kreiranje.unosLinije();
            Close();
        }
    }
}
