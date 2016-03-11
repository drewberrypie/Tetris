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
            //Assemble
            Board board = new Board();
            //Act
            Score s = new Score(board);
            //Assert
            Assert.IsInstanceOfType(s, typeof(Score));
        }
    }
}
