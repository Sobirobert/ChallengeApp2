using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieZWyzwania21
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Age { get; }
        string Gender { get; }

        void AddGrade(float grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        Statistics GetStatistics();
    }
}
