
using ZadanieZWyzwania21;

namespace TypeTest
{
    public class Tests
    {
       
        [Test]
        public void GetUserAndGradesShouldReturnMaxGrade()
        {
            //arange
            var employee1 = new Employee("Adam", "Wick", 34);
            employee1.AddGrade(3.1f);
            employee1.AddGrade(1);
            employee1.AddGrade(7.55f);
            employee1.AddGrade(8.99f);
            employee1.AddGrade(2);

            //act
            var statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(8.99f, statistics.Max);
        }
        public void GetUserAndGradesShouldReturnMinGrade()
        {
            //arange
            var employee2 = GetUser("Adam", "Dark", 44);
            employee2.AddGrade(5.2f);
            employee2.AddGrade(22);
            employee2.AddGrade(0.1f);
            employee2.AddGrade(0);
            employee2.AddGrade(33.333f);
            //act
            var statistics = employee2.GetStatistics();
            //assert
            Assert.AreEqual(0 ,statistics.Min);
        }
        public void GetUserAndGradesShouldReturnAverageGrades()
        {
            //arange
            var employee3 = GetUser("Mark", "Dark", 24);
            employee3.AddGrade(5.2f);
            employee3.AddGrade(22);
            employee3.AddGrade(0.1f);
            employee3.AddGrade(0);
            employee3.AddGrade(33.333f);
            //act
            var statistics = employee3.GetStatistics();
            //assert
            Assert.AreEqual(12.1266f, statistics.Average);
        }

        private Employee GetUser(string name, string lastName, int age)
        {
            return new Employee(name, lastName, age);
        }
    }
}