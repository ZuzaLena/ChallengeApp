
using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void EmployeeStatistics_ShouldReturnCorrectValues()
        {
            var employee1 = new Employee("Krzysztof", "Krawczyk");

            employee1.AddGrade(-6);
            employee1.AddGrade(15);
            employee1.AddGrade(4);
            employee1.AddGrade(5);
            employee1.AddGrade(-3);
            employee1.AddGrade(9);

            var statistics = employee1.GetStatistics();

            Assert.AreEqual(15, statistics.Max);

            Assert.AreEqual(-6, statistics.Min);

            Assert.AreEqual(4, statistics.Average);
 
            Assert.That(statistics.Sum, Is.EqualTo(24));
        }
    }
}
