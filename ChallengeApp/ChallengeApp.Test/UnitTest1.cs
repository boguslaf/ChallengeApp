namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // arrange
            var employee = new Employee("Hans", "Kloss", 35);
            employee.AddScore(1);
            employee.AddScore(3);
            employee.AddScore(-7);
            employee.AddScore(2);

            // act
            int result = employee.Result;

            // assert
            Assert.AreEqual(-1, result);
        }
    }
}