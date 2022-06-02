using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryLib;

namespace Inventura
{
    internal class InventoryList
    {
        public List<InventoryItem> list = new List<InventoryItem>();
        public void LoadItems()
        {
            Scanner scanner = new Scanner();
            List<string> entries = scanner.GetEntries();
            foreach (string entry in entries)
            {
                string[] polje = entry.Split(';');
                int id= int.Parse(polje[0]);
                string name = polje[1];
                int count = 0;
                InventoryItem item = new InventoryItem(id, name, count);
                AddItem(item);
            }
        }

        private void AddItem(InventoryItem item)
        {
            if (list.Count == 0)
            {
                item.Count = 1;
                list.Add(item);
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (item.Id == list[i].Id)
                    {
                        list[i].Count++;
                    }
                    else
                    {
                        if (i == list.Count - 1)
                        {
                            list.Add(item);
                        }
                    }
                }
            }
        }
    }
}
