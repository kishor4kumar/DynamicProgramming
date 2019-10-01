using NUnit.Framework;

namespace KnapsackBagTest
{
    public class MinimumCostTest
    {
        [Test]
        public void Sample1Test()
        {
            var result = KnapsackBag.Program.GetMinimumCost(new int[] { 1, 2, 3 }, 3, 2);
            Assert.AreEqual(2, result, "Minimum Cost is not correct");
        }

        [Test]
        public void Sample2Test()
        {
            var result = KnapsackBag.Program.GetMinimumCost(new int[] { -1, -1, 4, 5, -1 }, 5, 5);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Sample3Test()
        {
            var result = KnapsackBag.Program.GetMinimumCost(new int[] { 1, 2, 3, 4, 5 }, 5, 5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Sample4Test()
        {
            var result = KnapsackBag.Program.GetMinimumCost(new int[] { 1, 10, 4, 50, 100 }, 5, 5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Sample5Test()
        {
            var result = KnapsackBag.Program.GetMinimumCost(new int[] { 20, 10, 4, 50, 100 }, 5, 5);
            Assert.AreEqual(14, result);
        }
    }
}