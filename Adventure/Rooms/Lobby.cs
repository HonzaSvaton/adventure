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
        public override string Description => $"Dim lobby";

        public override string Name => "Lobby";
        public Lobby()
        {
        Additem(new Rock());
        Additem(new Potion());
        }
    
    }
    
    
}

