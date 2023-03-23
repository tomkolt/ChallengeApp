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
            employee.AddGrade(1);
            employee.AddGrade(2);

            // act
            var statistisc = employee.GetStatistics();

            // assert
            Assert.AreEqual(1, statistisc.Min);
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
        [Test]
        public void RatingsInLetters_ShouldCorrectAverageLetter()
        {
            // arrange
            var employee1 = new Employee();
            var employee2 = new Employee();
            var employee3 = new Employee();

            employee1.AddGrade('A');
            employee1.AddGrade('b');
            employee1.AddGrade(30);

            employee2.AddGrade(110);
            employee2.AddGrade(80);
            employee2.AddGrade(10);

            employee3.AddGrade('a');
            employee3.AddGrade('E');
            employee3.AddGrade('d');

            // act
            var averageLetter1 = employee1.GetStatistics();
            var averageLetter2 = employee2.GetStatistics();
            var averageLetter3 = employee3.GetStatistics();

            // assert
            Assert.AreEqual('B', averageLetter1.AverageLetter);
            Assert.AreEqual('C', averageLetter2.AverageLetter);
            Assert.AreEqual('C', averageLetter3.AverageLetter);
        }
    }
}