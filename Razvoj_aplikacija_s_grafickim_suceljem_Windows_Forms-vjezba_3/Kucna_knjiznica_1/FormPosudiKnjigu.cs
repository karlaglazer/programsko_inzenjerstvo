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
    public partial class FormPosudiKnjigu : Form
    {
        private Knjiznica knjiznica = new Knjiznica();
        private Knjiga knjiga = new Knjiga();
        private FormKnjige formKnjige = new FormKnjige();
        public FormPosudiKnjigu(Knjiga knjiga1)
        {
            InitializeComponent();
            knjiga = knjiga1;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
            formKnjige.Osvjezi();
            formKnjige.Show();
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            
            knjiznica.PosudiKnjigu(knjiga,txtOsoba.Text);
            Close();
            formKnjige.Osvjezi();
            formKnjige.Show();

        }

        private void FormPosudiKnjigu_Load(object sender, EventArgs e)
        {
            txtISBN.Text = knjiga.ISBN;
            txtNaslov.Text = knjiga.Naslov;
        }
    }
}
