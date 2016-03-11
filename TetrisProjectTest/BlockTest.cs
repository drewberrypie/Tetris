using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TetrisProject;

namespace TetrisProjectTest
{
    [TestClass]
    public class BlockTests
    {

        [TestMethod]
        public void Block_constuctedCorrectly()
        {
            //Assemble
            Board board = new Board();
            //Act
            Block b = new Block(board, new Point(4, 13), Color.Bisque);
            //Assert
            Assert.IsInstanceOfType(b, typeof(Block));
        }
        [TestMethod]
        public void TryMoveLeft_EnoughSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            //Act
            b.TryMoveLeft();
            //Assert
            Assert.IsTrue(b.TryMoveLeft());
        }
        [TestMethod]
        public void TryMoveLeft_NoSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            //Act
            b.TryMoveLeft();
            //Assert
            Assert.IsFalse(b.TryMoveLeft());
        }
        [TestMethod]
        public void TryMoveRight_EnoughSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            //Act
            b.TryMoveRight();
            //Assert
            Assert.IsTrue(b.TryMoveRight());
        }
        [TestMethod]
        public void TryMoveRight_NoSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(10, 0), Color.Bisque);
            //Act
            b.TryMoveRight();
            //Assert
            Assert.IsFalse(b.TryMoveRight());
        }
        [TestMethod]
        public void TryMoveDown_EnoughSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            //Act
            b.TryMoveDown();
            //Assert
            Assert.IsTrue(b.TryMoveDown());
        }
        [TestMethod]
        public void TryMoveDown_NoSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(0, 20), Color.Bisque);
            //Act
            b.TryMoveDown();
            //Assert
            Assert.IsFalse(b.TryMoveDown());
        }
        [TestMethod]
        public void TryRotate_EnoughSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            //Act
            b.TryRotate(new Point(1, 1));
            //Assert
            Assert.IsTrue(b.TryRotate(new Point(1, 1)));
        }
        [TestMethod]
        public void TryRotate_NoSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            //Act
            b.TryRotate(new Point(-1, -1));
            //Assert
            Assert.IsFalse(b.TryRotate(new Point(-1, -1)));
        }
        [TestMethod]
        public void TryRotate_BigOffset()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            //Act
            b.TryRotate(new Point(-15, -19));
            //Assert
            Assert.IsFalse(b.TryRotate(new Point(-15, -19)));
        }
        [TestMethod]
        public void MoveLeft_EnoughSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            //Act
            b.MoveLeft();
            //Assert
            Assert.AreEqual(4, b.Position.X);
        }
        [TestMethod]
        public void MoveLeft_NoSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            //Act
            b.MoveLeft();
            //Assert
            Assert.AreEqual(0, b.Position.X);
        }
        [TestMethod]
        public void MoveRight_EnoughSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            //Act
            b.MoveRight();
            //Assert
            Assert.AreEqual(6, b.Position.X);
        }
        [TestMethod]
        public void MoveRight_NoSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(10, 0), Color.Bisque);
            //Act
            b.MoveRight();
            //Assert
            Assert.AreEqual(10, b.Position.X);
        }
        [TestMethod]
        public void MoveDown_EnoughSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            //Act
            b.MoveDown();
            //Assert
            Assert.AreEqual(6, b.Position.Y);
        }
        [TestMethod]
        public void MoveDown_NoSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(0, 20), Color.Bisque);
            //Act
            b.MoveDown();
            //Assert
            Assert.AreEqual(20, b.Position.Y);
        }
        [TestMethod]
        public void Rotate_EnoughSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            //Act
            b.Rotate(new Point(-3, 2));
            //Assert
            Assert.AreEqual(new Point(2, 7), b.Position);
        }
        [TestMethod]
        public void Rotate_NoSpace()
        {
            //Assemble
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            //Act
            b.Rotate(new Point(-1, 5));
            //Assert
            Assert.AreEqual(new Point(0, 0), b.Position);
        }
    }
}
