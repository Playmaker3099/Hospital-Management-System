using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }


        public Person(string name, string gender, int age) 
        {
            Name = name;
            Gender = gender;
            Age = age;
        }
    }
}
