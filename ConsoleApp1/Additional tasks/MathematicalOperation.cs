using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_tasks
{
    internal class MathematicalOperation
    {
    
        public void AddOperation(double number1, double number2)
        {
            var resultAdd = number1 + number2;
            Console.WriteLine($" Result {number1} + {number2} = {resultAdd}");
        }

        public void SubtractionOperation(double numbers1, double numbers2)
        {
            var resultSubtraction = numbers1 - numbers2;
            Console.WriteLine($" Result {numbers1} - {numbers2} = {resultSubtraction}");
        }
        public void MultiplicationOperation(double numbers1, double numbers2)
        {
            var resultMultiplication = numbers1 * numbers2;
            Console.WriteLine($" Resul {numbers1} * {numbers2} = {resultMultiplication}");
        }
        public void DivisionOperation(double numbers1, double numbers2)
        {
            var resultDivision = numbers1 / numbers2;
            Console.WriteLine($" Resul {numbers1} / {numbers2} = {resultDivision}");
        }
    }
    
}
