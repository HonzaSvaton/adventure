using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Items;

namespace Adventure.Rooms
{
    public class Library : BaseRoom
    {
        public override string Name => "Library";
        public override string Description => "an old library, there are thousand of books covered in cobwebs";
        public override bool Locked { get; set; } = false;

        public Library()
        {
            Additem(new Key());
        }
    }
}
