using Adventure.Commands;

namespace Adventure
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var world = new World();
            var commands = RegisterCommands();

            Console.WriteLine(world.Intro);

            while (true)
            {
                Console.Write("-> ");
                var commandText = Console.ReadLine();

                if (commandText == "quit")
                {
                    break;
                }

                if (!string.IsNullOrEmpty(commandText))
                {
                    var parsedCommandText = commandText.Trim().Split(" ");
                    var command = commands.GetValueOrDefault(parsedCommandText[0]) ?? commands["help"];
                    command.Execute(world, parsedCommandText.Skip(1).ToArray());
                }
            }
        }

        private static Dictionary<string, BaseCommand> RegisterCommands() => new Dictionary<string, BaseCommand>()
        {
            { "look", new LookAroundCommand() },

            { "help", new HelpCommand() },

            { "info", new InfoCommand() },

            {"pickup", new PickUp() },
        };
    }
}
