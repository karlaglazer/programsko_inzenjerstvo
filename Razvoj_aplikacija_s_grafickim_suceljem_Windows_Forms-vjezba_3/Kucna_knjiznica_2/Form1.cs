using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib2;

namespace Kucna_knjiznica_2
{
    public partial class Form1 : Form
    {
        private Knjiznica knjiznica = new Knjiznica();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Osvjezi();
        }
        private void Osvjezi()
        {
            radioBtnSve.Checked = true;
                List<Posudba> listaKnjiga = knjiznica.DohvatiSvePosudbe().ToList();
                dataGridSve.DataSource = listaKnjiga;
                for (int i = 0; i < listaKnjiga.Count; i++)
                {
                    if (listaKnjiga[i].Vraceno == false)
                    {
                        dataGridSve.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridSve.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
        }

        private void radioBtnTrenutne_Click(object sender, EventArgs e)
        {
            List<Posudba> listaKnjiga = knjiznica.DohvatiTrenutnePosudbe().ToList();
            dataGridSve.DataSource = listaKnjiga;
            dataGridSve.DefaultCellStyle.BackColor = Color.Red;
        }

        private void radioBtnProsle_Click(object sender, EventArgs e)
        {
            List<Posudba> listaKnjiga = knjiznica.DohvatiProslePosudbe().ToList();
            dataGridSve.DataSource = listaKnjiga;
            dataGridSve.DefaultCellStyle.BackColor = Color.Green;
        }

        private void radioBtnSve_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void dataGridSve_SelectionChanged(object sender, EventArgs e)
        {
            Posudba odabranaPosudba = dataGridSve.CurrentRow.DataBoundItem as Posudba;
            if (odabranaPosudba.Vraceno == true)
            {
                btnVrati.Enabled = false;
            }
            else
            {
                btnVrati.Enabled = true;
            }
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            Posudba odabranaPosudba = dataGridSve.CurrentRow.DataBoundItem as Posudba;
            knjiznica.VratiKnjigu(odabranaPosudba);
            Osvjezi();
        }
    }
}
