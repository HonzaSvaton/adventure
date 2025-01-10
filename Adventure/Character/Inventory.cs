using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Character
{
    public class Inventory
    {
        private readonly List<BaseItem> items = new List<BaseItem> ();

        public IReadOnlyCollection<BaseItem> Items => items;

        public void PickItem(BaseItem item)
        {
            if (item.Pickable)
            {
                items.Add(item);
            }
        }

    }
}
 