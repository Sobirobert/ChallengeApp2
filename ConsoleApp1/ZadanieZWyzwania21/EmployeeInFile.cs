using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieZWyzwania21
{
    internal class EmployeeInFile : EmployeeBase
    {
        private List<float> Grades = new List<float>();
        public string Name { get; private set;}
        public string Surname { get; private set;}
        public string Age { get; private set;}
        public string Gender { get; private set;}

        private const string FileName = "grades.txt";
        public EmployeeInFile(string name, string surnane, string age, string gender) : 
            base(name, surnane, age, gender)
        {
            this.Name = name;
            this.Surname = surnane;
            this.Age = age;
            this.Gender = gender;
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.Grades.Add(grade);

                using (var writer = File.AppendText(FileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            {
                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;
                statistics.Average = 0;
                foreach (var grade in grades)
                {
                    if(grade >= 0)
                    {
                        statistics.Max = Math.Max(statistics.Max, grade);
                        statistics.Min = Math.Min(statistics.Min, grade);
                        statistics.Average += grade;    
                    }
                }

                statistics.Average /= grades.Count;

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
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{FileName}"))
            {
                using (var reader = File.OpenText($"{FileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

    }
}
