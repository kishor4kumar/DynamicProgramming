using NUnit.Framework;

namespace LcsTest
{
    public class EfficientTest
    {
        [Test]
        public void SmallStringTest()
        {
            Assert.AreEqual(4, Lcs.Efficient.GetLCS("AGGTAB", "GXTXAYB"));
        }

        [Test]
        public void LongStringTest()
        {
            Assert.AreEqual(12, Lcs.Efficient.GetLCS("ABCDEFGHIJKL", "AZBZCZDZEZFZGZHZIZJZKZLZ"));
        }
    }
}
