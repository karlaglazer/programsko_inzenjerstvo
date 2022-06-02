using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prijava
{
    public partial class PrijavnaForma : Form
    {
        public PrijavnaForma()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korIme = txtKorIme.Text;
            string lozinka = txtLozinka.Text;
            RepozitorijKorisnika repozitorij = new RepozitorijKorisnika();
            Korisnik korisnik = repozitorij.DohvatiKorisnika(korIme);
            Autentifikator autentifikator = new Autentifikator();
            if(autentifikator.Prijavikorisnika(korisnik.ID, lozinka) == true)
            {
                MessageBox.Show("Uspješna prijava!");
            }
            else
            {
                MessageBox.Show("Nesupješna prijava!");
            } 
        }
    }
}
