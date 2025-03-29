using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class GoCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (!@params.Any())
            {
                AnsiConsole.WriteLine("First you have to write where you want to go");
                return;
            }

            var room = world.CurrentRoom.Neighbours.FirstOrDefault(n => n.Name == @params[0]);
            if (room == null)
            {
                AnsiConsole.MarkupLine("You have used the right command but chose the wrong room. Please choose again");
                return;               
            } 
           var Open=world.SwitchRoom(room);
            if (Open)
            {
                AnsiConsole.MarkupLine($"[red]You have entered:{room.Name}[/]");
            }
           
        }    
            
    }
}
