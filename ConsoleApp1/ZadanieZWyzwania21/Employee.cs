using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZadanieZWyzwania21;

namespace ZadanieZWyzwania21
{
    public class Employee : IEmployee 
    {
       

        private List<float> Grades = new List<float>();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
          
        public Employee(string name, string surname, int age, string gender ) 
           
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Gender = gender;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100) 
            {
                this.Grades.Add(grade); 
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.Grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.Grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.Grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.Grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.Grades.Add(20);
                    break;
                default:
                    // this.grades.Add(0);
                    throw new Exception("Wrong Letter"); 
                    
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float number))
            {
                this.AddGrade(number);
            }
            else if(grade.Length == 1)
            {
                char a = char.Parse(grade);
                this.AddGrade(a);
            }
            else
            {
                throw new Exception("Incorrect value");
            }
            
        }

        public void AddGrade(double grade)
        {
            float number = Convert.ToSingle(grade);
            // float number = (float)grade;
            this.AddGrade(number);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.Grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.Grades.Count;

            switch (statistics.AverageLetter)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            
            return statistics;
        }
    }
}
