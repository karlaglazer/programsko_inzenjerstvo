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
    public partial class FormaDetaljiRacuna : Form
    {
        Racun odabraniRacun = new Racun();
        public FormaDetaljiRacuna(Racun racun)
        {
            InitializeComponent();
            odabraniRacun = racun;
        }

        private void FormaDetaljiRacuna_Load(object sender, EventArgs e)
        {
            txtIBAN.Text = odabraniRacun.IBAN;
            txtStanje.Text = odabraniRacun.Stanje.ToString();
            txtVlasnik.Text = odabraniRacun.Vlasnik;
            txtUkupno.Text = odabraniRacun.IzracunajUkupanPromet().ToString();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPopisTransakcija forma = new FormPopisTransakcija();
            forma.Show();

        }
    }
}
