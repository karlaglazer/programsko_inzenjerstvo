using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvedbaIspitaLib2;

namespace Provedba_ispita_2
{
    public partial class FormIspit : Form
    {
        static IspitManager ispitManager = new IspitManager();
        Pitanje pitanje;
        List<Odgovor> listaOdgovora;
        public FormIspit()
        {
            InitializeComponent();
        }

        private void FormIspit_Load(object sender, EventArgs e)
        {
            Sljedece();
        }

        private void Sljedece()
        {
            pitanje = ispitManager.SljedecePitanje();
            txtPitanje.Text = pitanje.Tekst;
            listaOdgovora = ispitManager.DohvatiOdgovore(pitanje);
            btnA.Text ="A)"+ listaOdgovora[0].ToString();
            btnB.Text ="B)"+ listaOdgovora[1].ToString();
            btnC.Text ="C)"+ listaOdgovora[2].ToString();
            btnD.Text ="D)"+ listaOdgovora[3].ToString();
            if (pitanje.Status == StatusPitanja.NijeOdgovoreno)
            {
                txtPitanje.BackColor = Color.Gray;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
            }
            else if (pitanje.Status == StatusPitanja.TocnoOdgovoreno)
            {
                txtPitanje.BackColor = Color.Green;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled= false;
                btnD.Enabled= false;
            }
            else
            {
                txtPitanje.BackColor = Color.Red;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
            }
            
        }
        private void Prethodno()
        {
            pitanje = ispitManager.PrethodnoPitanje();
            txtPitanje.Text = pitanje.Tekst;
            listaOdgovora = ispitManager.DohvatiOdgovore(pitanje).ToList();
            btnA.Text = "A) " + listaOdgovora[0].ToString();
            btnB.Text = "B) " + listaOdgovora[1].ToString();
            btnC.Text = "C) " + listaOdgovora[2].ToString();
            btnD.Text = "D) " + listaOdgovora[3].ToString();
            if (pitanje.Status == StatusPitanja.NijeOdgovoreno)
            {
                txtPitanje.BackColor = Color.Gray;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
            }
            else if (pitanje.Status == StatusPitanja.TocnoOdgovoreno)
            {
                txtPitanje.BackColor = Color.Green;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
            }
            else
            {
                txtPitanje.BackColor = Color.Red;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            ispitManager.PotvrdiPitanje(pitanje, listaOdgovora[0]);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            ispitManager.PotvrdiPitanje(pitanje, listaOdgovora[1]);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ispitManager.PotvrdiPitanje(pitanje, listaOdgovora[2]);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            ispitManager.PotvrdiPitanje(pitanje, listaOdgovora[3]);
        }

        private void btnPrethodno_Click(object sender, EventArgs e)
        {
            Prethodno();
        }

        private void btnSljedece_Click(object sender, EventArgs e)
        {
            Sljedece();
        }
    }
}
