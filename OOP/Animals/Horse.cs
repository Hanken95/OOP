using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal class Horse : Animal
    {
        public bool Rideable { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Neigh");
        }

        public override string Stats()
        {
            if (Rideable)
            {
                return base.Stats() + $", is rideable";
            }
            else
            {
                return base.Stats() + $", is not rideable";
            }
        }
    }
}
