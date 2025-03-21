using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class InventoryCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (world.Inventory.Items.Count == 0)
            {
                AnsiConsole.MarkupLine($"[blue]There is not anything in your inventory[/]");
            }
            else
                AnsiConsole.MarkupLine($"You looked into the inventory and see a [blue]{string.Join(",", world.Inventory.Items)}[/]");
        }
    }
}
