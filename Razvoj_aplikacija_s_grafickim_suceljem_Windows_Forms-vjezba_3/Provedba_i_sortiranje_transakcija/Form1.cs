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

namespace Provedba_i_sortiranje_transakcija
{
    public partial class FormPopisTransakcija : Form
    {
        private List<Transakcija> popisTransakcija = Banka.DohvatiPopisTransakcija().ToList();
        Transakcija transakcija = new Transakcija();
        public FormPopisTransakcija()
        {
            InitializeComponent();
        }

        private void FormPopisTransakcija_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }


        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            Banka.StornirajTransakciju(transakcija);
            popisTransakcija = Banka.DohvatiPopisTransakcija().ToList();
            Osvjezi();
        }
        private void Osvjezi()
        {
            popisTransakcija = Banka.DohvatiPopisTransakcija().ToList();
            dataGridViewPopis.DataSource = popisTransakcija;
            dataGridViewPopis.Refresh();
        }

        private void dataGridViewPopis_SelectionChanged(object sender, EventArgs e)
        {
            transakcija = dataGridViewPopis.CurrentRow.DataBoundItem as Transakcija;
        }

        private void btnProvedi_Click(object sender, EventArgs e)
        {
            FormProvedi formProvedi = new FormProvedi();
            formProvedi.ShowDialog();
            Osvjezi();
        }
    }
}
