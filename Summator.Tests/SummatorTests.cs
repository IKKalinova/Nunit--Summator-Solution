using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {

        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5,7});
            Assert.That(result==12);
            Assert.Pass();
        }

        [Test]
        public void Test_Sum_OnePossitiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5 });
            Assert.That(result == 5);
            Assert.Pass();
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            int result = Summator.Sum(new int[] { -5, -7 });
            Assert.That(result == -12);
            Assert.Pass();
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            int result = Summator.Sum(new int[] {  });
            Assert.That(result == 0);
            Assert.Pass();
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long result = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000});
            Assert.AreEqual(1705032704, result);
          //  Assert.Pass();
        }

        [Test]
        public void Test_AverageTwoPossitiveNumbers()
        {
            int expected = Summator.Average(new int[] { 2, 6});
            int actual = 4;
            Assert.That(expected==actual);
        }


        [Test]
        public void Test_AverageTwoNegativeNumbers()
        {
            int expected = Summator.Average(new int[] { -2, -6 });
            int actual = -4;
            Assert.That(expected == actual);
        }

    }
}