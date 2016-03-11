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
        [TestMethod]
        public void OnLineCleared_Triggered()
        {
            //Assemble
            Board board = new Board();
            List<int> receivedEvents = new List<int>();
            board.LinesCleared += delegate (int i)
            {
                receivedEvents.Add(i);
            };
            Shape s = new ShapeO(board);
            List<string> receivedEventsJoin = new List<string>();
            s.JoinPile += delegate (IShape x)
            {
                receivedEventsJoin.Add("triggered");
            };
            //Act
            s.Drop();
            //Assert
            Assert.AreEqual("triggered", receivedEventsJoin[0]);
            //Assert.AreEqual(0, receivedEvents[0]);

        }
    }
}
