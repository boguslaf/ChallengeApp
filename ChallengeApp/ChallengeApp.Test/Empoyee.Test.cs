namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            // arrange
            var employee = new Employee("Hans", "Kloss", 1922);
            employee.AddScore(10);
            employee.AddScore(30);
            employee.AddScore(25);
            employee.AddScore(15);

            // act
            var stat = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(20.00, 2), Math.Round(stat.Average, 2));
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Hans", "Kloss", 1922);
            employee.AddScore(10);
            employee.AddScore(30);
            employee.AddScore(25);
            employee.AddScore(15);

            // act
            var stat = employee.GetStatistics();

            // assert
            Assert.AreEqual(30, stat.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("Hans", "Kloss", 1922);
            employee.AddScore(10);
            employee.AddScore(30);
            employee.AddScore(25);
            employee.AddScore(15);

            // act
            var stat = employee.GetStatistics();

            // assert
            Assert.AreEqual(10, stat.Min);
        }
    }
}