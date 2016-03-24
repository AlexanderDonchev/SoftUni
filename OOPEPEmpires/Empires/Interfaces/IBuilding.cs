using Empires.Resources;
using Empires.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Interfaces
{
   public interface IBuilding
    {
        int TurnsElapsed { get; set; }
        int TurnsForUnit { get;}
        int TurnsForResource { get; }

        Unit ProduceUnit();
        Resource ProduceResource();
        bool CanProduceUnit();
        bool CanProduceResource();
    }
}
