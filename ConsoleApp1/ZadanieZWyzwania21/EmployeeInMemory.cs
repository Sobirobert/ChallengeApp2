using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieZWyzwania21
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> Grades = new List<float>();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        public string Gender { get; private set; }

        public EmployeeInMemory(string name, string surname, string age, string gender)
            : base(name, surname, age, gender) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Gender = gender;
        }

        public override void AddGrade(float grade)
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

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
         
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
