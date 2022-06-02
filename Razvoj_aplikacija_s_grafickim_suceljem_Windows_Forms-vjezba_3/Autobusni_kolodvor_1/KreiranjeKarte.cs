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
    public partial class KreiranjeKarte : Form
    {
        private VrstaKarte vrstaKarte { get; set; }
        private bool isPovratna { get; set; }
        private bool isPrtljaga { get; set; }
        public Linija linija1 { get; set; }
        public KreiranjeKarte()
        {
            InitializeComponent();
        }

        private void btnOdaberiLiniju_Click(object sender, EventArgs e)
        {
            Linije linija = new Linije();
            linija.Show();
            this.Hide();
        }
        public void unosLinije()
        {
            txtPolaziste.Text = linija1.Polaziste;
            txtOdrediste.Text = linija1.Odrediste;
            txtUdaljenost.Text = linija1.Udaljenost.ToString();
            txtPrijevoznik.Text = linija1.Autoprijevoznik;
            this.Show();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (rBtnRegularna.Checked)
            {
                vrstaKarte = VrstaKarte.Regularna;
            }
            else
            {
                vrstaKarte = VrstaKarte.Studentska;
            }
            isPovratna = cBoxPovratna.Checked;
            isPrtljaga = cBoxPrtljaga.Checked;
            Karta kreiranje = new Karta(linija1, vrstaKarte, isPovratna, isPrtljaga);
            txtBrojKarte.Text = kreiranje.BrojKarte.ToString();
            txtCijenaKarte.Text = kreiranje.Cijena.ToString();
        }
    }
}
