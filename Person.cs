using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()   
        {
            Name = "name";
            Surname = "surname";
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
