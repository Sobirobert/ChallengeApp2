using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieZWyzwania21
{
    public abstract class Person
    {
        public Person(string name, string surname, int age, int gender) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; private set; }    
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Gender { get; private set;}
    }
}
