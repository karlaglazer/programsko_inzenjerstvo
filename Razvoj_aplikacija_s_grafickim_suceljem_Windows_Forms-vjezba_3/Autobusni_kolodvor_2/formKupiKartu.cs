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
    public partial class formKupiKartu : Form
    {
        private Linija odabranaLinija = new Linija();
        private bool povratna { get; set; }
        private bool prtljaga { get; set; }
        public formKupiKartu()
        {
            InitializeComponent();
        }
        public void OdabranaLinija(Linija linija)
        {
            this.odabranaLinija = linija;
        }

        private void formKupiKartu_Load(object sender, EventArgs e)
        {
            comboBVrsta.DataSource = Enum.GetValues(typeof(VrstaKarte));
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            VrstaKarte vrstaKarte = (VrstaKarte)comboBVrsta.SelectedItem;
            povratna = checkBPovratna.Checked;
            prtljaga = checkBPrtljaga.Checked;
            Karta karta = new Karta(odabranaLinija,vrstaKarte, povratna,prtljaga);
            txtIspis.Text = $"Broj karte: {karta.BrojKarte}";
            txtIspis.Text+= $"\r\nRelacija: {karta.Linija.Polaziste}-{karta.Linija.Odrediste}" +
                $"\r\nUdaljenost: {karta.Linija.Udaljenost}" +
                $"\r\nAutoprijevoznik: {karta.Linija.Autoprijevoznik}" +
                $"\r\nVrsta karte: {karta.Vrsta}" +
                $"\r\nPovratna karta: {karta.Povratna}" +
                $"\r\nNaplati prtljagu: {karta.Prtljaga}" +
                $"\r\n-------------------" +
                $"\r\nCijena karte: {karta.Cijena}";
        }

    }
}
