using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Person
    {
        // Copy constructor.
        public Person(Person previousPerson)
        {
            Name = previousPerson.Name;
            Age = previousPerson.Age;
        }

        // Alternate copy constructor calls the instance constructor.
        //public Person(Person previousPerson)
        //    : this(previousPerson.Name, previousPerson.Age)
        //{
        //}

        // Instance constructor.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public string Details()
        {
            return Name + " is " + Age.ToString();
        }
    }
}
