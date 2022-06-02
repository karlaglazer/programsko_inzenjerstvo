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
    public partial class FormRezultati : Form
    {
        public FormRezultati()
        {
            InitializeComponent();
        }

        private void FormRezultati_Load(object sender, EventArgs e)
        {
            List<Pitanje> rezultati = IspitManager.DohvatiRezultate().ToList();
            dataGridViewRezultati.DataSource = rezultati;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
