using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsMale { get; set; }

        public void Greeting()
        {
            Console.WriteLine($"Hello my name is: {Name} and I am {Age} old!");
        }

    }
}
