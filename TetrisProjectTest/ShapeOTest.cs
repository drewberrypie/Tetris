using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TetrisProject;

namespace TetrisProjectTest
{
    [TestClass]
    public class ShapeOTest
    {
        [TestMethod]
        public void ShapeO_ConstructedCorrectly()
        {
            //Assemble
            Board b = new Board();
            //Act
            Shape t = new ShapeO(b);
            //Assert
            Assert.IsInstanceOfType(t, typeof(ShapeO));
        }
        [TestMethod]
        public void MoveLeft_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t.MoveLeft();
            Assert.AreEqual(new Point(3, 0), t[0].Position);
        }
        [TestMethod]
        public void MoveLeft_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t[0].Position = new Point(0, 0);
            t[1].Position = new Point(1, 0);
            t[2].Position = new Point(0, 1);
            t[3].Position = new Point(1, 1);
            t.MoveLeft();
            Assert.AreEqual(new Point(0, 0), t[0].Position);
        }
        [TestMethod]
        public void MoveRight_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t.MoveRight();
            Assert.AreEqual(new Point(5, 0), t[0].Position);
        }
        [TestMethod]
        public void MoveRight_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t[0].Position = new Point(9, 0);
            t[1].Position = new Point(10, 0);
            t[2].Position = new Point(9, 1);
            t[3].Position = new Point(10, 1);
            t.MoveRight();
            Assert.AreEqual(new Point(9, 0), t[0].Position);
        }
        [TestMethod]
        public void MoveDown_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t.MoveDown();
            Assert.AreEqual(new Point(4, 1), t[0].Position);
        }
        [TestMethod]
        public void MoveDown_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t[0].Position = new Point(4, 19);
            t[1].Position = new Point(5, 19);
            t[2].Position = new Point(4, 20);
            t[3].Position = new Point(5, 20);
            t.MoveDown();
            Assert.AreEqual(new Point(4, 19), t[0].Position);
        }
        [TestMethod]
        public void Drop_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t.Drop();
            Assert.AreEqual(new Point(4, 18), t[0].Position);
        }
        [TestMethod]
        public void Drop_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t[0].Position = new Point(4, 19);
            t[1].Position = new Point(5, 19);
            t[2].Position = new Point(4, 20);
            t[3].Position = new Point(5, 20);
            t.Drop();
            Assert.AreEqual(new Point(4, 19), t[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpaceFirstTime()
        {
            //Assemble
            Board b = new Board();
            Shape o = new ShapeO(b);
            o.Rotate();
            Assert.AreEqual(new Point(4, 0), o[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpaceSecondTime()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t.Rotate();
            t.Rotate();
            Assert.AreEqual(new Point(4, 0), t[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpaceThirdTime()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t.Rotate();
            t.Rotate();
            t.Rotate();
            Assert.AreEqual(new Point(4, 0), t[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpacLastTime()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t.Rotate();
            t.Rotate();
            t.Rotate();
            t.Rotate();
            Assert.AreEqual(new Point(4, 0), t[0].Position);
        }
        [TestMethod]
        public void Rotate_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape t = new ShapeO(b);
            t.Rotate();
            Assert.AreEqual(new Point(4, 0), t[0].Position);
        }
    }
}
