using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal class Flamingo : Bird
    {
        public int Eyes { get; set; }
        public override string Stats()
        {
            if (CanFly)
            {
                return base.Stats() + $", can fly, has {Eyes} eyes, ";
            }
            else
            {
                return base.Stats() + $", cannot fly, has {Eyes} eyes, ";
            }
        }
    }
    }
}
