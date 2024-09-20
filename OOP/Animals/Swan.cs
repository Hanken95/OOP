using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal class Swan : Bird
    {
        public int Feathers { get; set; }

        public override string Stats()
        {
            if (CanFly)
            {
                return base.Stats() + $", can fly, has {Feathers} feathers";
            }
            else
            {
                return base.Stats() + $", cannot fly, has {Feathers} feathers";
            }
        }
    }
}
