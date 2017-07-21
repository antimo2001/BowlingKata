using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingKata;

namespace BowlingKataTestProject
{
    [TestClass]
    public class BowlingGameTests
    {
        BowlingGame game;

        [TestInitialize]
        public void InitializeBowlingGame()
        {
            game = new BowlingGame();
        }
        [TestMethod]
        public void GutterBallTest()
        {
            ManyOpenFrames(10, 0, 0);
            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void BowlThreePinsPerThrowTest()
        {
            ManyOpenFrames(10, 3, 3);
            Assert.AreEqual(60, game.Score());
        }

        [TestMethod]
        public void BowlSpareTest()
        {
            game.Spare(4, 6);
            game.OpenFrame(5, 3);
            ManyOpenFrames(8, 0, 0);
            int expectedScore = (4 + 6 + 5 + 5 + 3);
            Assert.AreEqual(expectedScore, game.Score());
        }

        private void ManyOpenFrames(int frameTotalCount, int firstThrow, int secondThrow)
        {
            for (int i = 0; i < frameTotalCount; i++)
            {
                game.OpenFrame(firstThrow, secondThrow);
            }
        }
    }
}
