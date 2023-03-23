namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGotRatings_ShouldCorrectMaxResult()
        {
            // arrange
            var employee = new Employee("Tom", "Kolt", 34);
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(8);
            employee.AddGrade(4);

            // act
            var statistisc = employee.GetStatistics();

            // assert
            Assert.AreEqual(8, statistisc.Max);
        }
        [Test]
        public void WhenEmployeeGotRatings_ShouldCorrectMinResult()
        {
            // arrange
            var employee = new Employee("Tom", "Kolt", 34);
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(-5);
            employee.AddGrade(-6);

            // act
            var statistisc = employee.GetStatistics();

            // assert
            Assert.AreEqual(-6, statistisc.Min);
        }
        [Test]
        public void WhenEmployeeGotRatings_ShouldCorrectAverageResult()
        {
            // arrange
            var employee = new Employee("Tom", "Kolt", 34);
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            

            // act
            var statistisc = employee.GetStatistics();

            // assert
            Assert.AreEqual(3.33, Math.Round(statistisc.Average,2));
        }
    }
}