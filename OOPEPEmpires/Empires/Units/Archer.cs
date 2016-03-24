using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Units
{
    class Archer:Unit
    {
        public Archer()
        {
            base.AttackDamage = 7;
            base.Health = 25;
        }
    }
}
