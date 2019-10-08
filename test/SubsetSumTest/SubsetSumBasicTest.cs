using NUnit.Framework;

namespace SubsetSumTest
{
    public class SubsetSumBasicTest
    {
        [Test]
        public void BasicTest1()
        {
            Assert.IsTrue(SubsetSum.Program.IsSubsetSumPossible(new int[] { 6, 8, 3, 4 }, 9));
        }

        [Test]
        public void BasicTest2()
        {
            Assert.IsTrue(SubsetSum.Program.IsSubsetSumPossible(new int[] { 6, 8, 1, 4 }, 7));
        }

        [Test]
        public void BasicTest3()
        {
            Assert.IsTrue(SubsetSum.Program.IsSubsetSumPossible(new int[] { 3, 8, 1, 5, 2 }, 19));
        }

        [Test]
        public void BasicNegativeTest1()
        {
            Assert.IsFalse(SubsetSum.Program.IsSubsetSumPossible(new int[] { 6, 8, 2, 4 }, 7));
        }


        [Test]
        public void BasicNegativeTest2()
        {
            Assert.IsFalse(SubsetSum.Program.IsSubsetSumPossible(new int[] { 6, 7, 10, 9 }, 5));
        }


        [Test]
        public void BasicNegativeTest3()
        {
            Assert.IsFalse(SubsetSum.Program.IsSubsetSumPossible(new int[] { 2, 5, 1, 5, 11, 13 }, 9));
        }
    }
}