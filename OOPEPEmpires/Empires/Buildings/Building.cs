using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Resources;
using Empires.Units;

namespace Empires.Buildings
{
    abstract class Building : IBuilding
    {

        virtual public int TurnsElapsed { get; set; }

        virtual public int TurnsForResource { get; }

        virtual public int TurnsForUnit { get; }

        abstract public Resource ProduceResource();

        abstract public Unit ProduceUnit();

        public bool CanProduceUnit()
        {
            if (TurnsElapsed % TurnsForUnit == 0 && TurnsElapsed!=0)
            {
                return true;
            }
            else { return false; }
        }

        public bool CanProduceResource()
        {
            if(TurnsElapsed%TurnsForResource==0 && TurnsElapsed!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
