using ConsoleApp1;

namespace ChallengeApp.Test
    
{
    public class Tests
    {
        
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // ARRANGE 
            var employee4 = new Employee("Adam", "Wick", 33);
            employee4.AddScore(5);
            employee4.AddScore(6);  
            //act
            var result = employee4.pointsOfEmployee;

            //assert
            Assert.AreEqual(11, result);

        }

        [Test]
        public void WhenUserCollectDifferentScores_ShouldCorrectResult()
        {
            // ARRANGE 
            var employee5 = new Employee("Bob", "Wick", 53);
            employee5.AddScore(-3);
            employee5.AddScore(6);
            employee5.AddScore(8);
            employee5.AddScore(11);
            employee5.AddScore(-20);
            //act
            var result = employee5.pointsOfEmployee;

            //assert
            Assert.AreEqual(2, result);

        }

        [Test]
        public void WhenUserCollectMinusScores_ShouldCorrectResult()
        {
            // ARRANGE 
            var employee4 = new Employee("Adam", "Wick", 33);
            employee4.AddScore(-9);
            employee4.AddScore(-16);
            //act
            var result = employee4.pointsOfEmployee;

            //assert
            Assert.AreEqual(-25, result);

        }
    }
}