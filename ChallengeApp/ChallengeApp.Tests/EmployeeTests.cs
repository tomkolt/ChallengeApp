namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectFourPositiveScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Tom", "Kolt", 34);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(5);
            employee.AddScore(4);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(20, result);
        }
        [Test]
        public void WhenEmployeeCollectTwoPositiveAndTwoNegativeScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Tom", "Kolt", 34);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-5);
            employee.AddScore(-6);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(0, result);
        }
    }
}