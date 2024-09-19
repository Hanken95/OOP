using OOP.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal class WolfMan : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("Rawr I'm a wolfman woof woof xD");
        }
    }
}
