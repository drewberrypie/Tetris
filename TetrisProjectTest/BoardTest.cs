using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TetrisProject;

namespace TetrisProjectTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void Board_constructedCorrectly()
        {
            Board board = new Board();
            Assert.IsInstanceOfType(board, typeof(Board));
        }
        [TestMethod]
        public void GetLength_WithinScope()
        {
            Board board = new Board();
            int i = board.GetLength(0);
            Assert.AreEqual(10, i);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetLength_OutsideScope()
        {
            Board board = new Board();
            int i = board.GetLength(3);
        }
    }
}
