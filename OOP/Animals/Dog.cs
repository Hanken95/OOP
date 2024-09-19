using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal class Dog : Animal
    {
        private bool huntingDog;

        public bool HuntingDog
        {
            get { return huntingDog; }
            set { huntingDog = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof");
        }
    }
}
