using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal class Wolf : Animal
    {
        public int NumberOfTeeth { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Grr");
        }
    }
}
