
namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void EmployeeScoreCheckWhenPositive_ShouldReturnCorretSum()
        {
            var user1 = new Employee("Adam", "Nowak", 32, 0);
            
            user1.AddScore(5);
            user1.AddScore(6);
            user1.AddScore(9);

            var result1 = user1.Result;

            Assert.AreEqual(20, result1);
            
        }
        [Test]
        public void EmployeeScoreCheckWhenReduced_ShouldReturnCorretSum()
        {

            var user2 = new Employee("Zuza", "Kamiñska", 35, 0);

            user2.AddScore(6);
            user2.AddScore(-5);
            user2.AddScore(7);

            var result2 = user2.Result;

            Assert.AreEqual(8, result2);

        }
        [Test]
        public void EmployeeScoreCheckWhenNegative_ShouldReturnCorretSum()
        {
            var user3 = new Employee("Lena", "Kowalska", 29, 0);

            user3.AddScore(2);
            user3.AddScore(3);
            user3.AddScore(-9);

            var result3 = user3.Result;


            Assert.AreEqual(-4, result3);
        }
    }
    
     
}