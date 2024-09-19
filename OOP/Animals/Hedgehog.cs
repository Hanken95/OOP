using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal class Hedgehog : Animal
    {
        public bool IsCute { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("click");
        }

        public override string Stats()
        {
            if (IsCute)
            {
                return base.Stats() + $", is cute";
            }
            else
            {
                return base.Stats() + $", is not cute";
            }
        }
    }
}
