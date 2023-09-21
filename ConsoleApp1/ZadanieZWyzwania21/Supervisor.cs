﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieZWyzwania21
{
    internal class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public string name => throw new NotImplementedException();

        public string surname => throw new NotImplementedException();

        public void AddGrade(float grade)
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

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
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
                    // this.grades.Add(0);
                    throw new Exception("Wrong Letter");

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
            throw new NotImplementedException();
        }
    }
}
