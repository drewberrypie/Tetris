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
            //Assemble
            Board board = new Board();
            //Act N/A
            //Assert
            Assert.IsInstanceOfType(board, typeof(Board));
        }
        [TestMethod]
        public void GetLength_WithinScope()
        {
            //Assemble
            Board board = new Board();
            //Act
            int i = board.GetLength(0);
            //Assert
            Assert.AreEqual(10, i);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetLength_OutsideScope_IndexOutOfRange()
        {
            //Assemble
            Board board = new Board();
            //Act
            int i = board.GetLength(3);
            //Assert (Catch exception)
        }
        [TestMethod]

    }
}
