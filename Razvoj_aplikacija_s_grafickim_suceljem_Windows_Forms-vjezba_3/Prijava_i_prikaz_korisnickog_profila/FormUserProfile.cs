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
    public partial class FormUserProfile : Form
    {
        User korisnik = null;
        public FormUserProfile()
        {
            InitializeComponent();
        }
        public void Prijavljeni(User user)
        {
            korisnik=user;
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            txtFirst.Text = korisnik.FirstName;
            txtLast.Text = korisnik.LastName;
            txtUser.Text = korisnik.UserName;
            txtPass.Text = korisnik.Password;
            if (korisnik.UserType == UserType.Administrator)
            {
                radioBtnAdmin.Checked = true;
            }
            else if(korisnik.UserType == UserType.Guest)
            {
                radioBtnGuest.Checked = true;
            }
            else
            {
                radioBtnEmployee.Checked = true;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Autentificator.LogOut();
            Close();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }
    }
}
