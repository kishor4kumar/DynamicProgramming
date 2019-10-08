using NUnit.Framework;

namespace LisTest
{
    public class LisBasicTest
    {

        [Test]
        public void SmallArrayTest()
        {
            Assert.AreEqual(4, Lis.Program.GetLIS(new int[] { 3, 4, -1, 0, 6, 2, 3 }));
        }

        [Test]
        public void LongArrayTest()
        {
            Assert.AreEqual(6, Lis.Program.GetLIS(new int[] { 10, 1, 2, 5, 4, 5, 7, 10 }));
        }
    }
}