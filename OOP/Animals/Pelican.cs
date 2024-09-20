using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal class Pelican : Bird
    {
        public int Legs { get; set; }

        public override string Stats()
        {
            if (CanFly)
            {
                return base.Stats() + $", can fly, has {Legs} legs";
            }
            else
            {
                return base.Stats() + $", cannot fly, has {Legs} legs";
            }
        }
    }
}
