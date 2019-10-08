using NUnit.Framework;

namespace KnapsackTest
{
    public class MaxValueTest
    {
        [Test]
        public void BasicMaxValueTest()
        {
            Assert.AreEqual(220, Knapsack.Program.GetMaxValue(new int[] { 60, 100, 120 }, new int[] { 1, 2, 3 }, 5));
        }

        [Test]
        public void BasicMaxValueTest2()
        {
            Assert.AreEqual(220, Knapsack.Program.GetMaxValue(new int[] { 120, 100, 60 }, new int[] { 3, 2, 1 }, 5));
        }

        [Test]
        public void BasicMaxValueTest3()
        {
            Assert.AreEqual(285, Knapsack.Program.GetMaxValue(new int[] { 60, 100, 120, 40, 5 }, new int[] { 1, 2, 3, 2, 1 }, 7 ));
        }
    }
}