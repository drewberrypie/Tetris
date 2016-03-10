using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TetrisProject;

namespace TetrisProjectTest
{
    [TestClass]
    public class ScoreTest
    {
        [TestMethod]
        public void Score_ConstructedCorrectly()
        {
            Board board = new Board();
            Score s = new Score(board);
            Assert.IsInstanceOfType(s, typeof(Score));
        }
    }
}
