using Empires.Buildings;
using Empires.Interfaces;
using Empires.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Resources;

namespace Empires.Core
{
    public class Empire:IDatabase
    {
      
       public List<IBuilding> Buildings { get; }
       public List<IUnit> Units { get; }
      public  Dictionary<Resources.ResourceType,int> Resources { get; }


        public Empire()
        {
            this.Buildings = new List<IBuilding>();
            this.Units = new List<IUnit>();
            this.Resources = new Dictionary<Empires.Resources.ResourceType, int>();
        }


        public void AddUnit(IUnit unit)
        {
            this.Units.Add(unit);
        }

        public void AddBuilding(IBuilding buidling)
        {
            this.Buildings.Add(buidling);
        }

        public void AddResource(IResource resource)
        {
            if (this.Resources.ContainsKey(resource.ResourceType))
             {
                this.Resources[resource.ResourceType] += resource.Quantity;
             }
            else
            {
                this.Resources.Add(resource.ResourceType, 0);
                this.Resources[resource.ResourceType] += resource.Quantity;
            }
        }
    }


}
