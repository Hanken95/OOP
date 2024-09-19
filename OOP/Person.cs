using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
		public Person(int age, string fName, string lName, double height, double weight) 
		{
			this.age = age;
			this.fName = fName;
			this.lName = lName;
			this.height = height;
			this.weight = weight;
		}

        public Person()
        {

        }


        private int age;

		public int Age
		{
			get { return age; }
			set 
			{
                if (value < 1)
                {
					throw new ArgumentException("Age cannot be below 1");
                }
                age = value; 
			}
		}
		private string fName;

		public string FName
		{
			get { return fName; }
			set 
			{
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot be null");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name cannot be shorter than 2 characters");
                }
                if (value.Length > 10)
                {
                    throw new ArgumentException("Last name cannot be longer than 10 characters");
                }
                fName = value; 
			}
		}
		private string lName;

		public string LName
		{
			get { return lName; }
			set 
			{
                if (value == null)
                {
					throw new ArgumentNullException("Cannot be null");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be shorter than 3 characters");
                }
                if (value.Length > 15)
                {
                    throw new ArgumentException("Last name cannot be longer than 15 characters");
                }
                lName = value; 
			}
		}
		private double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}
		private double weight;

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}

	}
}
