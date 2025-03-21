using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    internal class Test_Command : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            AnsiConsole.MarkupLine("[gold1]test[/]");
        }
    }
}
