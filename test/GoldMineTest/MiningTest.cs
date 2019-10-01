using NUnit.Framework;

namespace GoldMineTest
{
    public class MiningTest
    { 
        [Test]
        public void SampleInput1Test()
        {
            int[,] gold = new int[,]{{1, 3, 1, 5},
                                {2, 2, 4, 1},
                                {5, 0, 2, 3},
                                {0, 6, 1, 2}
                                };

            var result = GoldMine.Program.GetMaxGold(gold, 4, 4);

            Assert.AreEqual(16, result);

        }

        [Test]
        public void SampleInput2Test()
        {
            int[,] gold = new int[,]{{1, 3, 3},
                   {2, 1, 4},
                  {0, 6, 4}};

            var result = GoldMine.Program.GetMaxGold(gold, 3, 3);

            Assert.AreEqual(12, result);

        }

        [Test]
        public void SampleInput3Test()
        {
            int[,] gold = new int[,]{{10, 33, 13, 15},
                  {22, 21, 04, 1},
                  {5, 0, 2, 3},
                  {0, 6, 14, 2}};

            var result = GoldMine.Program.GetMaxGold(gold, 4, 4);

            Assert.AreEqual(83, result);

        }
    }
}