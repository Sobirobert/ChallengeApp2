using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieZWyzwania21
{
    public class Supervisor : IEmployee
    {
        private List<float> Grades = new List<float>();

        public string Name {get; private set;}

        public string Surname { get; private set; }

        public Supervisor(string name, string surname) 
        { 
            this.Name = name;
            this.Surname = surname;
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
            switch (grade)
            {
                case "6":
                    this.Grades.Add(100);
                    break;
                case "5":
                    this.Grades.Add(80);
                    break;
                case "4":
                    this.Grades.Add(60);
                    break;
                case "3":
                    this.Grades.Add(40);
                    break;
                case "-3":
                case "3-":
                    this.Grades.Add(35);
                    break;
                case "+2":
                case "2+":
                    this.Grades.Add(25);
                    break;
                case "2":
                    this.Grades.Add(20);
                    break;
                case "1":
                    this.Grades.Add(0);
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
