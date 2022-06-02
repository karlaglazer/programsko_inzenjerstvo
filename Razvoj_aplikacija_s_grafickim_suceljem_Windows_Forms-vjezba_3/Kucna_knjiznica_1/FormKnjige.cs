using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib;

namespace Kućna_knjižnica_1
{
    public partial class FormKnjige : Form
    {
        static Knjiznica knjiznica = new Knjiznica();
        public FormKnjige()
        {
            InitializeComponent();   
        }

        private void FormKnjige_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        public void Osvjezi()
        {
            List<Knjiga> dostupneKnjige = knjiznica.DohvatiDostupneKnjige().ToList();
            dataGridDostupne.DataSource = dostupneKnjige;
            List<Knjiga> posudjeneKnjige = knjiznica.DohvatiKnjigeNaPosudbi().ToList();
            dataGridPosudjene.DataSource = posudjeneKnjige;
            dataGridDostupne.Refresh();
            dataGridPosudjene.Refresh();
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            Knjiga knjiga = dataGridDostupne.CurrentRow.DataBoundItem as Knjiga;
            FormPosudiKnjigu formPosudiKnjigu = new FormPosudiKnjigu(knjiga);
            this.Hide();
            formPosudiKnjigu.Show();
            Osvjezi();
        }
    }
}
