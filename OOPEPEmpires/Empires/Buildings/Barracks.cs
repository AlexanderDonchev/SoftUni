using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Resources;
using Empires.Units;

namespace Empires.Buildings
{
    class Barracks : Building
    {
        private int turnsElapsed;
        private int turnsForResource;
        private int turnsForUnit;

        public Barracks()
        {
            this.turnsElapsed = -1;
            this.turnsForResource = 3;
            this.turnsForUnit = 4;
        }

        public override int TurnsElapsed
        {
            get
            {
                return this.turnsElapsed;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Turns Elapsed cannot be negative");
                }
                this.turnsElapsed = value;
            }
        }
        public override int TurnsForUnit
        {
            get
            {
                return this.turnsForUnit;
            }
        }
        public override int TurnsForResource
        {
            get
            {
                return this.turnsForResource;
            }
        }

        public override Resource ProduceResource()
        {
            return new Resource(ResourceType.Steel, 10);
        }

        public override Unit ProduceUnit()
        {
            return new Swordsman();
        }
    }
}
