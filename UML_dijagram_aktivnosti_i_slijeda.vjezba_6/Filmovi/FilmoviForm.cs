using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmovi
{
    public partial class FilmoviForm : Form
    {
        public FilmoviForm()
        {
            InitializeComponent();
        }

        private void FilmoviForm_Load(object sender, EventArgs e)
        {
            StreamingServis streamingServis = new StreamingServis();
            List<Film> zapocetiFilmovi = streamingServis.DohvatiZapoceteFilmove();
            PrikaziFilmove(zapocetiFilmovi);
        }

        private void PrikaziFilmove(List<Film> zapocetiFilmovi)
        {
            dgvFilmovi.DataSource = zapocetiFilmovi;
        }
    }
}
