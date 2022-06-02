using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventura
{
    public partial class ReportForm : Form
    {

        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            InventoryList list = new InventoryList();
            list.LoadItems();
            PrintList(list.list);
            
        }

        private void PrintList(List<InventoryItem> list)
        {
            richTxtReport.AppendText("INVENTORY LIST:\r\n");
            richTxtReport.AppendText("----------------\r\n");
            foreach (var red in list)
            {
                richTxtReport.AppendText($"Id = {red.Id}, Name = {red.Name}, Count = {red.Count}\r\n");
            }
        }
    }
}
