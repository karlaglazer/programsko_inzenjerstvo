using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvedbaIspitaLib;

namespace Provedba_ispita
{
    public partial class FormProvedba : Form
    {
        Pitanje pitanje;
        public FormProvedba()
        {
            InitializeComponent();
        }

        private void FormProvedba_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Osvjezi()
        {
            if (IspitManager.ImaJosPitanja() == true)
            {
                listBMoguciOdgovori.Items.Clear();
                txtPotvrdjeni.Text = null;
                pitanje = IspitManager.SljedecePitanje();
                txtPitanje.Text = pitanje.Tekst;
                List<Odgovor> list = pitanje.DohvatiOdgovore();
                foreach(Odgovor odgovor in list)
                {
                    listBMoguciOdgovori.Items.Add(odgovor);
                }
            }
            else
            {
                FormRezultati formRezultati = new FormRezultati();
                formRezultati.Show();
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Odgovor odgovor = listBMoguciOdgovori.SelectedItem as Odgovor;
            txtPotvrdjeni.Text = odgovor.Tekst;
            pitanje.PotvrdiOdgovor(odgovor);
        }

        private void btnSljedece_Click(object sender, EventArgs e)
        {
            if (txtPotvrdjeni.Text.Length == 0)
            {
                MessageBox.Show("Morate potvrditi odgovor.");
            }
            else
            {
                Osvjezi();
            }
        }
    }
}
