using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Units
{
    class Swordsman:Unit
    {
      

        public Swordsman()
        {
            base.AttackDamage = 13;
            base.Health = 40;
        }
    }
}
