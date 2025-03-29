using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    public class Armour : BaseItem
    {
        public override string Name => "Armour";

        public override string Description => "A red armour made by harvesting lava";

        public override int Weight => 25;

    }
}
