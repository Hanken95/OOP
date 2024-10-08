﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal class Bird : Animal
    {
        private bool canFly;

        public bool CanFly
        {
            get { return canFly; }
            set { canFly = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("Chirp");
        }
        public override string Stats()
        {
            if (canFly)
            {
                return base.Stats() + $", can fly";
            }
            else
            {
                return base.Stats() + $", cannot fly";
            }
        }
    }
}
