
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
            employee1.AddGrade("B");
            employee1.AddGrade(7.55f);
            employee1.AddGrade(8.99f);
            employee1.AddGrade(2);

            //act
            var statistics = employee1.GetStatisticsWhitForEach();

            //assert
            Assert.AreEqual(80, statistics.Max);
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
            var statistics = employee2.GetStatisticsWhitForEach();
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
            var statistics = employee3.GetStatisticsWhitForEach();
            //assert
            Assert.AreEqual(12.1266f, statistics.Average);
            Assert.AreEqual('E', statistics.AverageLetter);
        }
        public void GetUserAndGradesShouldReturnAverageLetter()
        {
            //arange
            var employee4 = GetUser("Zuzia", "Maracje", 18);
            employee4.AddGrade("a");
            employee4.AddGrade("c");
            employee4.AddGrade(10);
            employee4.AddGrade(20);
            employee4.AddGrade(333);
            //act
            var statistics = employee4.GetStatisticsWhitForEach();
            //assert
            Assert.AreEqual(38, statistics.Average);
            Assert.AreEqual('D', statistics.AverageLetter);
        }


        private Employee GetUser(string name, string lastName, int age)
        {
            return new Employee(name, lastName, age);
        }
    }
}