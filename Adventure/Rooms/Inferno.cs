using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Items;

namespace Adventure.Rooms
{
    public class Inferno : BaseRoom
    {
        public override string Description => "A room that looks like hell";

        public override string Name => "Inferno";

        public override bool Locked { get; set; } = false;

        public Inferno()
        {
            Additem(new Armour());
        }
        

    }
}
