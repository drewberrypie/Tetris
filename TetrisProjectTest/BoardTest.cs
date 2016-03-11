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
        public void GameOver_EventFired()
        {
            //Assemble
            Board board = new Board();
            List<string> receivedEvents = new List<string>();
            board.GameOver += delegate ()
            {
                receivedEvents.Add("Game Over triggered");
            };
            //Act
            board.OnGameOver();
            //Assert
            Assert.AreEqual(1, receivedEvents.Count);
            Assert.AreEqual("Game Over triggered", receivedEvents[0]);
        }
    }
}
