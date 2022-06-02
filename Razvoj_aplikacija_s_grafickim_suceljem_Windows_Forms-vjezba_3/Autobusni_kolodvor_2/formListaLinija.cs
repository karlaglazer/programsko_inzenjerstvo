using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib2;

namespace Autobusni_kolodvor_2
{
    public partial class formListaLinija : Form
    {
        static AutobusniKolodvor aKolodvor  = new AutobusniKolodvor();
        public formListaLinija()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Linija> listaLinija = aKolodvor.DohvatiLinije();
            dataGridPopis.DataSource = listaLinija;
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            List<Linija> listaLinija = aKolodvor.DohvatiLinije(txtOdrediste.Text);
            dataGridPopis.DataSource = listaLinija;
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            Linija odabranaLinija = dataGridPopis.CurrentRow.DataBoundItem as Linija;
            formKupiKartu formaKupi = new formKupiKartu();
            formaKupi.OdabranaLinija(odabranaLinija);
            formaKupi.Show();
            
        }
    }
}
