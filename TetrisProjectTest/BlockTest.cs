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
            Board board = new Board();
            Block b = new Block(board, new Point(4, 13), Color.Bisque);
            Assert.IsInstanceOfType(b, typeof(Block));
        }
        [TestMethod]
        public void TryMoveLeft_EnoughSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            b.TryMoveLeft();
            Assert.IsTrue(b.TryMoveLeft());
        }
        [TestMethod]
        public void TryMoveLeft_NoSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            b.TryMoveLeft();
            Assert.IsFalse(b.TryMoveLeft());
        }
        [TestMethod]
        public void TryMoveRight_EnoughSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            b.TryMoveRight();
            Assert.IsTrue(b.TryMoveRight());
        }
        [TestMethod]
        public void TryMoveRight_NoSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(10, 0), Color.Bisque);
            b.TryMoveRight();
            Assert.IsFalse(b.TryMoveRight());
        }
        [TestMethod]
        public void TryMoveDown_EnoughSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            b.TryMoveDown();
            Assert.IsTrue(b.TryMoveDown());
        }
        [TestMethod]
        public void TryMoveDown_NoSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(0, 20), Color.Bisque);
            b.TryMoveDown();
            Assert.IsFalse(b.TryMoveDown());
        }
        [TestMethod]
        public void TryRotate_EnoughSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            b.TryRotate(new Point(1, 1));
            Assert.IsTrue(b.TryRotate(new Point(1, 1)));
        }
        [TestMethod]
        public void TryRotate_NoSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            b.TryRotate(new Point(-1, -1));
            Assert.IsFalse(b.TryRotate(new Point(-1, -1)));
        }
        [TestMethod]
        public void TryRotate_BigOffset()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            b.TryRotate(new Point(-15, -19));
            Assert.IsFalse(b.TryRotate(new Point(-15, -19)));
        }
        [TestMethod]
        public void MoveLeft_EnoughSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            b.MoveLeft();
            Assert.AreEqual(4, b.Position.X);
        }
        [TestMethod]
        public void MoveLeft_NoSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            b.MoveLeft();
            Assert.AreEqual(0, b.Position.X);
        }
        [TestMethod]
        public void MoveRight_EnoughSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            b.MoveRight();
            Assert.AreEqual(6, b.Position.X);
        }
        [TestMethod]
        public void MoveRight_NoSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(10, 0), Color.Bisque);
            b.MoveRight();
            Assert.AreEqual(10, b.Position.X);
        }
        [TestMethod]
        public void MoveDown_EnoughSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            b.MoveDown();
            Assert.AreEqual(6, b.Position.Y);
        }
        [TestMethod]
        public void MoveDown_NoSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(0, 20), Color.Bisque);
            b.MoveDown();
            Assert.AreEqual(20, b.Position.Y);
        }
        [TestMethod]
        public void Rotate_EnoughSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(5, 5), Color.Bisque);
            b.Rotate(new Point(-3, 2));
            Assert.AreEqual(new Point(2, 7), b.Position);
        }
        [TestMethod]
        public void Rotate_NoSpace()
        {
            Board board = new Board();
            Block b = new Block(board, new Point(0, 0), Color.Bisque);
            b.Rotate(new Point(-1, 5));
            Assert.AreEqual(new Point(0, 0), b.Position);
        }
    }
}
