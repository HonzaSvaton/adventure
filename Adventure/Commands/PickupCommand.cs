using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class PickupCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (!@params.Any())
            {
                AnsiConsole.MarkupLine($"[gold1]First you have to write what you want to pick up!!!!!!![/]");
                return;
            }
            var item = world.CurrentRoom.Items.FirstOrDefault(n => n.Name == @params[0]);
            if (item == null)
            {
                AnsiConsole.MarkupLine($"[gold1]You have used the right command but choose the wrong item name. Please choose again[/]");
                return;
            }
            world.CurrentRoom.Items.Remove(item);
            var result=world.Inventory.Additem(item);
            if (result)
            {
                AnsiConsole.MarkupLine($"[gold1]You have picked up a {item.Name}[/]");
            }
           
         
        }
    }
}
