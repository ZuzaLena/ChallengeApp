

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TheEmployeesAreDifferent()
        {
            //arrange
            var Employee1 = GetEmployee("Anna", "Nowak", 26, 0);
            var Employee2 = GetEmployee("Jan", "Nowak", 26, 0);


            //act


            //assert
            Assert.AreNotEqual(Employee1, Employee2);
        }
        [Test]
        public void TheSurnamesAreTheSame()
        {
            //arrange
            string surname1 = "Nowak";
            string surname2 = "Nowak";


            //act


            //assert
            Assert.AreEqual(surname1, surname2);
        }

        private Employee GetEmployee(string name, string surname, int age, int score)
        {
            return new Employee(name, surname, age, score);

        }
        [Test]
        public void TheNumbersAreTheEqual()
        {
            //arrange
            int number1 = 5;
            int number2 = 5;


            //act


            //assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void TheNumbersAreNotEqual()
        {
            //arrange
            float number3 = 569.589f;
            float number4 = -5865.586f;
            

            //act


            //assert
            Assert.AreNotEqual(number3, number4);


        }
    }
}
