namespace ChallengeApp.Test
{

    public class ValueType
    {
        [Test]
        public void WhenCompareTwoInt_ShouldBeDefference()
        {
            int number1 = 100;
            int number2 = 101;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenCompareTwoValueType_ShouldBeTheSame()
        {
            float number3 = 3.14F;
            string number4 = "3.14";

            Assert.AreNotEqual(number3, number4);
        }

    }
}
