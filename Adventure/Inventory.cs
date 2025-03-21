using Adventure.Items;
using Adventure.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Inventory
    {
        public List<BaseItem> Items = new List<BaseItem>();
        public void Additem(BaseItem item)
        {
            Items.Add(item);
        }
        public void Removeitem(BaseItem item)
        {
            Items.Remove(item);
        }

    }
}
