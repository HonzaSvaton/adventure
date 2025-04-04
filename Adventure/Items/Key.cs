using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    public class Key : BaseItem
    {
        public override string Name => "Key";

        public override string Description => "An old looking key with an emerald in the middle";

        public override int Weight => 2;

        public override Usability IsUsable { get; } = Usability.Inv;

        public override void Use (World world)
        {
            var room = world.CurrentRoom.Neighbours.
                Find(r => r.Name == "Corridor");
            room.Locked = false;
        }

    }
}
