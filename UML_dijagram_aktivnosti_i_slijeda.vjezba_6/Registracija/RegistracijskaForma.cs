using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registracija
{
    public partial class RegistracijskaForma : Form
    {
        public RegistracijskaForma()
        {
            InitializeComponent();
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            Registrator registrator = new Registrator();
            if(registrator.Registriraj(ime, prezime) == true)
            {
                MessageBox.Show("Korisnik uspješno dodan!");
            }
            else
            {
                MessageBox.Show("Nije dodan.");
            }
        }
    }
}
