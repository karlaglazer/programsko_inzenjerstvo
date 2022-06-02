using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervacija_sobe
{
    public partial class RezervacijskaForma : Form
    {
        private Recepcija recepcija = new Recepcija();
        private List<HotelskaSoba> slobodneSobe = new List<HotelskaSoba>();
        public RezervacijskaForma()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            DateTime datum = dtpDatumRezervacije.Value;
            slobodneSobe.Clear();
            slobodneSobe = recepcija.DohvatiSlobodneSobe(datum);
            dgvSlobodneSobe.Refresh();
            dgvSlobodneSobe.DataSource = slobodneSobe;
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            HotelskaSoba hotelskaSoba = dgvSlobodneSobe.CurrentRow.DataBoundItem as HotelskaSoba;
            DateTime datum = dtpDatumRezervacije.Value;
            recepcija.RezervirajSobu(hotelskaSoba, datum);
        }
    }
}
