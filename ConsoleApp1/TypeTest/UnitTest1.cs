
using ConsoleApp1;

namespace TypeTest
{
    public class Tests
    {
       
        [Test]
        public void GetUserShouldReturnTheSameLastName()
        {
            //arange
            var employee1 = GetUser("Adam", "Wick", 34);
            var employee2 = GetUser("Adam", "Wick", 34);
            //act

            //assert
            Assert.AreEqual(employee1.lastName,employee2.lastName);
        }
        public void GetUserShouldReturnDifferentObjects()
        {
            //arange
            var employee1 = GetUser("Adam", "Dark", 34);
            var employee2 = GetUser("Adam", "Wick", 34);
            //act

            //assert
            Assert.AreNotEqual(employee1.lastName, employee2.lastName);
        }

        public void GetIntNumbersShouldReturnDifferentObjects()
        {
            //arange
            int number1 = 5;
            int number2 = 10;
            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }
        public void GetIntNumbersShouldReturnTheSameObects()
        {
            //arange
            int number1 = 10;
            int number2 = 10;
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }
        public void GetFloatNumbersShouldReturnTheSameObects()
        {
            //arange
            float number1 = 2.7182f;
            float number2 = 2.7182f;
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }
        public void GetFloatNumbersShouldReturnDifferentObjects()
        {
            //arange
            float number1 = 2.718f;
            float number2 = 2.717f;
            
            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }
        public void GetStringValueShouldReturnTheSameObects()
        {
            //arange
            string string1 = "Czerwony Pomidor";
            string string2 = "Czerwony Pomidor";
            //act

            //assert
            Assert.AreEqual(string1, string2);
        }
        public void GetStringValueShouldReturnDifferentObjects()
        {
            //arange
            string string1 = "Zielony Pomidor";
            string string2 = "Czerwony Pomidor";
            //act

            //assert
            Assert.AreNotEqual(string1, string2);
        }

        private Employee GetUser(string name, string lastName, int age)
        {
            return new Employee(name, lastName, age);
        }
    }
}