using Adventure.Rooms;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class LookAroundCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            AnsiConsole.MarkupLine($"You looked around and see a [green]{world.CurrentRoom.Description}[/]");
            if (world.CurrentRoom.Items.Count == 0)
            {
                AnsiConsole.MarkupLine($"[blue]There is not anything for you to pick up[/]");
            }
            else
            { 
                AnsiConsole.MarkupLine($"You looked around and see a [blue]{string.Join(",", world.CurrentRoom.Items)}[/]");
            }
            AnsiConsole.MarkupLine($"You looked around and see a [red]{string.Join(",",world.CurrentRoom.Neighbours)}[/]");
        }   

    }
}
