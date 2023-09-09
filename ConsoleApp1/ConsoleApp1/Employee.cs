using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {


        private List<int> score = new List<int>();

        public string name { get; private set; }
        public string lastName { get; private set; }
        public int age { get; private set; }
        public int pointsOfEmployee 
        {
            get 
            {
                return this.score.Sum();
            } 
        }

        public Employee(string name, string lastName, int age ) 
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public void AddScore( int score )
        {
            this.score.Add(score);
        }
       
    }
}
