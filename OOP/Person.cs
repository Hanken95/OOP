using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
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

		public required string FName
		{
			get { return fName; }
			set 
			{
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

		public required string LName
		{
			get { return lName; }
			set 
			{
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
		private int height;

		public int Height
		{
			get { return height; }
			set { height = value; }
		}
		private int weight;

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}

	}
}
