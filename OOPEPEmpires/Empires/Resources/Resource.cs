using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Resources
{
    public enum ResourceType
    {
        Gold,Steel
    }

   public class Resource : IResource
    {
        private ResourceType resourceType;
        private int quantity;

        public Resource(ResourceType resourceType,int quantity)
        {
            this.ResourceType = resourceType;
            this.Quantity = quantity;
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                if (value<0)
                {
                    throw new ArgumentException("A resource cannot have a quantity of 0");
                }
                this.quantity = value;
            }
        }

        public ResourceType ResourceType
        {
            get
            {
                return this.resourceType;
            }

            set
            {
                this.resourceType = value;
            }
        }
    }


}
