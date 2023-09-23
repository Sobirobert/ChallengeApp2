using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieZWyzwania21
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Age { get; private set; }

        public string Gender { get; private set; }

        public EmployeeBase(string name, string surnane, string age, string gender)
        {
            this.Name = name;
            this.Surname = surnane;
            this.Age = age;
            this.Gender = gender;
        }

        public abstract void AddGrade(float grade);
        public void AddGrade(char grade)
        {
            int result = 0;
            switch (grade)

            {
                case 'A':
                case 'a':
                    result = 100;
                    break;
                case 'B':
                case 'b':
                    result = 80;
                    break;
                case 'C':
                case 'c':
                    result = 60;
                    break;
                case 'D':
                case 'd':
                    result = 40;
                    break;
                case 'E':
                case 'e':
                    result = 20;
                    break;
                default:
                    throw new Exception("Wrong Letter");

            }
            AddGrade(result);
        }
        public virtual void AddGrade(string grade)
        {
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
        }
        public void AddGrade(double grade)
        {
            float number = Convert.ToSingle(grade);
            this.AddGrade(number);
        }
        public abstract Statistics GetStatistics();
    }
}
