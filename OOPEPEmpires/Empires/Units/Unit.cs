using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Units
{
   abstract public class Unit:IUnit
    {
        private int health;
        private int attackDamage;

       virtual public int Health
        {
            get { return this.health; }
           protected set
            {
                if (value <0)
                {
                    throw new ArgumentException("A unit's health cannot be negative");
                }
                this.health = value;
            }
        }
       virtual public int AttackDamage
        {
            get { return this.attackDamage; }
           protected set
            {
                if (value<0)
                {
                    throw new ArgumentException("A unit's attack damage cannot be 0");
                }
                this.attackDamage = value;
            }
        }
    }
}
