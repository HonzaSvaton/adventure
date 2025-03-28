using Adventure.Items;
using Adventure.Rooms;
using Spectre.Console;
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
        public bool Additem(BaseItem item)
        {
            if (Items.Sum(x => x.Weight) + item.Weight > MaxCapacity)
            {
                AnsiConsole.MarkupLine($"[red]This is too heavy to pick up[/]");
                return false;
            }
            Items.Add(item);
            return true;
        }
        public void Removeitem(BaseItem item)
        {
            Items.Remove(item);
        }
        public int MaxCapacity => 20;

    }
}
