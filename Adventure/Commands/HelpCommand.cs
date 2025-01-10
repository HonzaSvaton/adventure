using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class HelpCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            Console.WriteLine("To interact with the game, use following commands ...");
            Console.WriteLine("---");
            Console.WriteLine("look - looks around the room");

            Console.WriteLine();
            Console.WriteLine("help - shows this help");
            Console.WriteLine("quit - exits the game");
        }
    }
}
