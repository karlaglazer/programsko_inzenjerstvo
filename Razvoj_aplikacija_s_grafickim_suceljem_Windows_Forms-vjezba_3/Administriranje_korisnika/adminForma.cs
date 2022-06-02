using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administriranje_korisnika
{
    public partial class adminForma : Form
    {
        public adminForma()
        {
            InitializeComponent();
        }

        private void adminForma_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Osvjezi()
        {
            List<AutentifikacijaLib.User> korisnici = AutentifikacijaLib.UsersRepository.GetUsers();
            korisniciDataGrid.DataSource = korisnici;
  
        }
        private AutentifikacijaLib.User DohvatiKorisnika()
        {
            AutentifikacijaLib.User korisnik = null;
            if(korisniciDataGrid.CurrentRow != null)
            {
                korisnik = korisniciDataGrid.CurrentRow.DataBoundItem as AutentifikacijaLib.User;
            }
            return korisnik;
        }


        private void btnActivate_Click(object sender, EventArgs e)
        {
            AutentifikacijaLib.User korisnik = DohvatiKorisnika();
            korisnik.Status = AutentifikacijaLib.UserStatus.Activated;
            btnActivate.Enabled = false;
            btnDeactivate.Enabled = true;
            korisniciDataGrid.Refresh();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            AutentifikacijaLib.User korisnik = DohvatiKorisnika();
            korisnik.Status = AutentifikacijaLib.UserStatus.Deactivated;
            btnActivate.Enabled = true;
            btnDeactivate.Enabled = false;
            korisniciDataGrid.Refresh();
        }

        private void korisniciDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            AutentifikacijaLib.User korisnik = DohvatiKorisnika();
            if(korisnik.Status == AutentifikacijaLib.UserStatus.Activated)
            {
                btnActivate.Enabled = false;
                btnDeactivate.Enabled = true;
            }
            else
            {
                btnActivate.Enabled = true;
                btnDeactivate.Enabled = false;
            }
            korisniciDataGrid.Refresh();
        }

    }
}
