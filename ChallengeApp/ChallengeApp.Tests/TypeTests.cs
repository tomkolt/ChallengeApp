using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetSameDoubleShouldReturnEquals()
        {
            // arrange
            double number1 = 18.05;
            double number2 = 18.05;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void GetSameFloatShouldReturnEquals()
        {
            // arrange
            float number1 = 18.05f;
            float number2 = 18.05f;
            
            // act

            // assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void GetSameStringShouldReturnEquals()
        {
            // arrange
            string number1 = "Tom";
            string number2 = "Tom";

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            // arrange
            var emp1 = GetSurnameEmployee("Tom", "Kolt", 34, 'M');
            var emp2 = GetSurnameEmployee("Mat", "Kolt", 30, 'M');

            // act


            // assert
            Assert.AreNotEqual(emp1, emp2);
        }
        [Test]
        public void GetSameEmployeeSurnameShouldReturnEquals()
        {
            // arrange
            var emp1 = GetSurnameEmployee("Tom", "Kolt", 34, 'M');
            var emp2 = GetSurnameEmployee("Mat", "Kolt", 30, 'M');

            // act


            // assert
            Assert.AreEqual(emp1.Surname, emp2.Surname);
        }

        private Employee GetSurnameEmployee(string name, string surname, int age, char sex)
        {
            return new Employee(name, surname, age, sex);
        }
    }
}
