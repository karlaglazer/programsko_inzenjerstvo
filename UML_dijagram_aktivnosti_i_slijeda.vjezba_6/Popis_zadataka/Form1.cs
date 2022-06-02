using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popis_zadataka
{
    public partial class Form1 : Form
    {
        private List<Zadatak> popisZadataka = new List<Zadatak>();
        private List<NoviZadatak> listaNovihZadataka = new List<NoviZadatak>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStvori_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            DateTime datum = dtpDatum.Value;
            NoviZadatak noviZadatak = new NoviZadatak(naziv, datum);
            popisZadataka.Add(noviZadatak.Zadatak);
            listaNovihZadataka.Add(noviZadatak);
            Osvjezi();
        }

        private void Osvjezi()
        {
            popisZadataka.Sort((x, y) =>x.DatumIVrijeme.CompareTo(y.DatumIVrijeme));
            dgvPopisZadataka.DataSource = null;
            dgvPopisZadataka.DataSource = popisZadataka;
            DataGridViewRowCollection rows = dgvPopisZadataka.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                foreach (var zadatak in listaNovihZadataka)
                {
                    if(zadatak.Zadatak == rows[i].DataBoundItem as Zadatak)
                    {
                        if (zadatak.Crvena == true)
                        {
                            rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
            dgvPopisZadataka.Refresh();
        }
    }
}
