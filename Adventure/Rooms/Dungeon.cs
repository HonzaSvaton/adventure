using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Dungeon : BaseRoom
    {
        public override string Name => "Dungeon";
        public override string Description => "Dark and smelly romm wtih water dripping form the cileing";

        public override bool Locked { get; set; } = false;
    }
}
