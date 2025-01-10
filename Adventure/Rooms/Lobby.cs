using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Lobby : BaseRoom
    {
        public override string Description => "room";

        public override string Name => "Lobby";

        public Lobby()
        
        {
            var rock = new Rock()

            { Pickable = true };
            
            
            Items.Add(rock);

        }
    }
}
