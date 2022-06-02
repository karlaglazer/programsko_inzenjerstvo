using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popis_zadataka_09
{
    public partial class Form1 : Form
    {
        private List<NoviZadatak> listaNovih = new List<NoviZadatak>();
        private List<Zadatak> popisZadataka = new List<Zadatak>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            DateTime rok = dtpDatum.Value;
            NoviZadatak novi = new NoviZadatak(naziv, rok);
            listaNovih.Add(novi);
            popisZadataka.Add(novi.Zadatak);
            popisZadataka.Sort((x,y) =>x.Naziv.CompareTo(y.Naziv));
            Prikazi();
        }

        private void Prikazi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = popisZadataka;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                foreach (var zadatak in listaNovih)
                {
                    if(zadatak.Zadatak == popisZadataka[i])
                    {
                        if(zadatak.Crvena == true)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}
