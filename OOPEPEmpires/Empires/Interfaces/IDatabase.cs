using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Interfaces
{
   public interface IDatabase
    {
        List<IBuilding> Buildings { get; }
        List<IUnit> Units { get; }
        Dictionary<Resources.ResourceType, int> Resources { get; }

        void AddResource(IResource resource);
    }
}
