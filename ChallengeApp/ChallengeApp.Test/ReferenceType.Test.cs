namespace ChallengeApp.Test
{
    public class ReferenceType
    {
        [Test]
        public void WhenCompareTwoObjects_SchuldBeDifferent()
        {
            // arrange
            var emp1 = GetEmployee("Kajko", 45);
            var emp2 = GetEmployee("Kokosz", 45);

            // assert
            Assert.AreNotEqual(emp1, emp2);
            Assert.AreNotEqual(emp1.Name, emp2.Name);
        }

        [Test]
        public void WhenCompareTwoParametersObjects_SchuldBeTheSame()
        {
            // arrange
            var emp1 = GetEmployee("Kajko", 45);
            var emp2 = GetEmployee("Kokosz", 45);

            // assert
            Assert.AreEqual(emp1.Age, emp2.Age);
        }

        private Employee GetEmployee(string name, int age)
        {
            return new Employee(name, age);
        }

    }
}
