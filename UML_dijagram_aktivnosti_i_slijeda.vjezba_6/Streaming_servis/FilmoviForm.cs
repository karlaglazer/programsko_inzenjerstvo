using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streaming_servis
{
    public partial class FilmoviForm : Form
    {
        StreamServis streamServis = new StreamServis();
        public FilmoviForm()
        {
            InitializeComponent();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            List<Film> neodgledaniFilmovi = streamServis.DohvatiNeodgledaneFilmove();
            dgvNepogledani.DataSource = null;
            dgvNepogledani.DataSource = neodgledaniFilmovi;
        }

        private void btnPogledaj_Click(object sender, EventArgs e)
        {
            Film odabraniFilm = dgvNepogledani.CurrentRow.DataBoundItem as Film;
            streamServis.PogledajFilm(odabraniFilm);
        }
    }
}
