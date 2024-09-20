using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal class Worm : Animal
    {
        public int NumberOfHearts { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("slither");
        }
        public override string Stats()
        {
            return base.Stats() + $", has {NumberOfHearts} hearts";
        }
    }
}
