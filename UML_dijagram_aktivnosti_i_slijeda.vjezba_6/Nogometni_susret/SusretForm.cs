using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogometni_Susret
{
    public partial class SusretForm : Form
    {
        public SusretForm()
        {
            InitializeComponent();
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            string oznakaDomacin = txtDomacin.Text;
            string oznakaGost = txtGost.Text;
            string rezultat = txtRezultat.Text;
            Susret susret = KontrolaSusreta.EvidentirajSusret(oznakaDomacin, oznakaGost, rezultat);
            MessageBox.Show($"{susret.Domacin.Naziv} {susret.BrojPogodakaDomacin} : {susret.BrojPogodakaGost} {susret.Gost.Naziv}");
        }
    }
}
