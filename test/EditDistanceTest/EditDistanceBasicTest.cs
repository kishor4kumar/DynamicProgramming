using NUnit.Framework;

namespace EditDistanceTest
{
    public class EditDistanceBasicTest
    {
        [Test]
        public void SmallStringTest()
        {
            Assert.AreEqual(1,EditDistance.Program.GetEditDistance("abc", "abd"));
        }

        [Test]
        public void MediumStringTest()
        {
            Assert.AreEqual(2, EditDistance.Program.GetEditDistance("Batman", "Batwoman"));
        }

        [Test]
        public void BigStringTest()
        {
            Assert.AreEqual(8, EditDistance.Program.GetEditDistance("ThisSucksToTheCore", "ThisDoesntSucksToTheCrores"));
        }
    }
}