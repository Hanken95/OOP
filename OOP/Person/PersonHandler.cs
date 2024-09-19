using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Person
{
    public class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            return new Person(age, fname, lname, height, weight);
        }

        public void ChangeName(Person person, string newFName = "", string newLName = "")
        {
            if (newFName != "")
            {
                person.FName = newFName;
            }
            if (newLName != "")
            {
                person.LName = newLName;
            }
        }

        public void GrowTaller(Person person, double heightGain)
        {
            if (heightGain < 0)
            {
                throw new ArgumentException("Cannot gein height lower than 0");
            }
            else
            {
                person.Height += heightGain;
            }
        }

        public void ChangeWeight(Person person, double weightChange)
        {
            person.Weight += weightChange;
        }
    }
}
