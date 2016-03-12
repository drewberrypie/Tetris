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
        public void OnJoinPile_Triggered()
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
        }
        [TestMethod]
        public void Shape_NotNull()
        {
            //Assemble
            Board board = new Board();
            Console.WriteLine(board.Shape.Name);
            //Assert
            Assert.IsNotNull(board.Shape);
        }
        [TestMethod]
        public void ShapeProxy_NotNull()
        {
            //Assemble
            Board board = new Board();
            ShapeProxy shape = new ShapeProxy(board);
            //Act
            Console.WriteLine(shape.Name);
            shape.DeployNewShape();
            Console.WriteLine(shape.Name);
            //Assert
            Assert.IsNotNull(shape);
        }
    }
}
