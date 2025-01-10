using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class InfoCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
           var item = world.CurrentRoom.Items.FirstOrDefault(


                i => i.Name == @params[0]

                );

            if ( item == null )
            {

                Console.WriteLine("This is not here!");
                return;
            }

            Console.WriteLine(item.Description);
        }
    }
}
