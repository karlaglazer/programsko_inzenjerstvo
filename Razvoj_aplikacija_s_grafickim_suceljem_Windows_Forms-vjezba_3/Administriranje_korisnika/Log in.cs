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

namespace Administriranje_korisnika
{
    public partial class logInForm : Form
    {
        
        public logInForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Autentificator.LogIn(txtUsername.Text, txtPassword.Text);
            if (Autentificator.LoggedUser.UserType != UserType.Administrator)
            {
                MessageBox.Show("You must be administrator to login!");
            }
            else
            {
                adminForma admin = new adminForma();
                admin.Show();
            }
        }
    }
}
