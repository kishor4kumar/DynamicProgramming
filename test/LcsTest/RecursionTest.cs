    using NUnit.Framework;

namespace LcsTest
{
    public class RecursionTest
    {
        [Test]
        public void SmallStringTest()
        {
            Assert.AreEqual(4, Lcs.Recursion.GetLCS("AGGTAB", "GXTXAYB"));
        }

        [Test]
        public void LongStringTest()
        {
            Assert.AreEqual(12, Lcs.Recursion.GetLCS("ABCDEFGHIJKL", "AZBZCZDZEZFZGZHZIZJZKZLZ"));
        }
    }
}