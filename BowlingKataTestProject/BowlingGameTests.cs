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
            game.OpenFrame(3, 5);
            ManyOpenFrames(8, 0, 0);
            int expectedScore = (4 + 6 + 3 + 3 + 5);
            Assert.AreEqual(expectedScore, game.Score());
        }

        [TestMethod]
        public void BowlSpareTest2()
        {
            ManyOpenFrames(7, 0, 0);
            game.Spare(4, 6);
            game.OpenFrame(5, 3);
            game.OpenFrame(2, 1);
            int expectedScore = (4 + 6 + 5 + 5 + 3 + 2 + 1);
            Assert.AreEqual(expectedScore, game.Score());
        }

        [TestMethod]
        public void BowlSpareTest3()
        {
            ManyOpenFrames(2, 0, 0);
            game.Spare(2, 8);
            game.Spare(4, 6);
            game.Spare(8, 2);
            game.OpenFrame(5, 3);
            ManyOpenFrames(4, 0, 0);
            int expectedScore = 2 + 8 + 4;
            expectedScore += 4 + 6 + 8;
            expectedScore += 8 + 2 + 5;
            expectedScore += 5 + 3;
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
