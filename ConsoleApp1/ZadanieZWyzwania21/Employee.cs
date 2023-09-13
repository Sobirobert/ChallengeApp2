using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieZWyzwania21;

namespace ZadanieZWyzwania21
{
    public class Employee
    {


        private List<float> grades = new List<float>();

        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }
      
        public Employee(string name, string surname, int age ) 
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }
     
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();  
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach ( var grade in this.grades ) 
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;    
            return statistics;
        }
    }
}
