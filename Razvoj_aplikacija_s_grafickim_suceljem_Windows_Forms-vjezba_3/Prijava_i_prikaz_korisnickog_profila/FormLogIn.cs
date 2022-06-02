using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutentifikacijaLib;

namespace Prijava_i_prikaz_korisničkog_profila
{
    public partial class FormLogIn : Form
    {
        private User korisnik = null;
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Autentificator.LogIn(txtUsername.Text, txtPassword.Text);
            korisnik = Autentificator.LoggedUser;
            if (txtUsername.Text.Length==0 || txtPassword.Text.Length == 0){
                MessageBox.Show("Username and password must be entered!");
            }
            else if(korisnik==null)
            {
                MessageBox.Show("Entered credentials are not valid!");
            }
            else
            {
                FormUserProfile formUserProfile = new FormUserProfile();
                formUserProfile.Prijavljeni(korisnik);
                this.Hide();
                formUserProfile.Show();
            }
        }


    }
}
