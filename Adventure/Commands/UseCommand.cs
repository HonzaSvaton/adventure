using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class UseCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (!@params.Any())
            {
                Console.WriteLine("You did not specify what item you want to use!!!!!");
                return;
            }
            var item = world.Inventory.Items.Find(i => i.Name == @params[0]);
            if (item != null && item.IsUsable == Items.Usability.Inv)
            {
                item.Use(world);
                return;
            }   

            item = world.CurrentRoom.Items.Find(i => i.Name == @params[0]);
            if (item != null && item.IsUsable == Items.Usability.Room)
            {
                item.Use(world);
                return;
            }
            

        }
    }
}
