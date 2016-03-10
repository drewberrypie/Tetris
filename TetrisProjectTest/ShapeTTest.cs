using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TetrisProject;

namespace TetrisProjectTest
{
    [TestClass]
    public class ShapeTTest
    {
        [TestMethod]
        public void ShapeT_ConstructedCorrectly()
        {
            //Assemble
            Board b = new Board();
            //Act
            Shape t = new ShapeT(b);
            //Assert
            Assert.IsInstanceOfType(t, typeof(ShapeT));
        }
        [TestMethod]
        public void MoveLeft_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeT(b);
            t.MoveLeft();
            Assert.AreEqual(new Point(3, 0), t[0].Position);
        }
        [TestMethod]
        public void MoveLeft_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeT(b);
            t[0].Position = new Point(0, 0);
            t[1].Position = new Point(1, 0);
            t[2].Position = new Point(2, 0);
            t[3].Position = new Point(1, 1);
            t.MoveLeft();
            Assert.AreEqual(new Point(0, 0), t[0].Position);
        }
        [TestMethod]
        public void MoveRight_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeT(b);
            t.MoveRight();
            Assert.AreEqual(new Point(5, 0), t[0].Position);
        }
        [TestMethod]
        public void MoveRight_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeT(b);
            t[0].Position = new Point(8, 0);
            t[1].Position = new Point(9, 0);
            t[2].Position = new Point(10, 0);
            t[3].Position = new Point(9, 1);
            t.MoveRight();
            Assert.AreEqual(new Point(8, 0), t[0].Position);
        }
        [TestMethod]
        public void MoveDown_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeT(b);
            t.MoveDown();
            Assert.AreEqual(new Point(4, 1), t[0].Position);
        }
        [TestMethod]
        public void MoveDown_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeT(b);
            t[0].Position = new Point(4, 19);
            t[1].Position = new Point(5, 19);
            t[2].Position = new Point(6, 19);
            t[3].Position = new Point(5, 20);
            t.MoveDown();
            Assert.AreEqual(new Point(4, 19), t[0].Position);
        }
        [TestMethod]
        public void Drop_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeT(b);
            t.Drop();
            Assert.AreEqual(new Point(4, 19), t[0].Position);
        }
        [TestMethod]
        public void Drop_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeT(b);
            t[0].Position = new Point(4, 19);
            t[1].Position = new Point(5, 19);
            t[2].Position = new Point(6, 19);
            t[3].Position = new Point(5, 20);
            t.Drop();
            Assert.AreEqual(new Point(4, 19), t[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeT(b);
            t.Rotate();
            Assert.AreEqual(new Point(4, 19), t[0].Position);
        }
        [TestMethod]
        public void Rotate_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeT(b);
            t[0].Position = new Point(4, 19);
            t[1].Position = new Point(5, 19);
            t[2].Position = new Point(6, 19);
            t[3].Position = new Point(5, 20);
            t.Drop();
            Assert.AreEqual(new Point(4, 19), t[0].Position);
        }
    }
}
