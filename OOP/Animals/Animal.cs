using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    internal abstract class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name: {name}, Age: {age}, Weight: {weight}";
        }
        protected Animal()
        {

        }
    }
}
