using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieZWyzwania21
{
    public class Supervisor : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public string Name {get; private set;}
        public string Surname { get; private set; }

        public string Age {get; private set;}

        public string Gender {get; private set;}

        public Supervisor(string name, string surname, string age, string gender)
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
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "+2":
                case "2+":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    if (float.TryParse(grade, out float number))
                    {
                        this.AddGrade(number);
                    }
                    else if (grade.Length == 1)
                    {
                        char a = char.Parse(grade);
                        this.AddGrade(a);
                    }
                    else
                    {
                        throw new Exception("Incorrect value");
                    }
                    break;
            }     
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

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
