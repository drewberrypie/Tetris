using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TetrisProject;

namespace TetrisProjectTest
{
    [TestClass]
    public class ShapeZTest
    {
        [TestMethod]
        public void ShapeZ_ConstructedCorrectly()
        {
            //Assemble
            Board b = new Board();
            //Act
            Shape s = new ShapeZ(b);
            //Assert
            Assert.IsInstanceOfType(s, typeof(ShapeZ));
        }
        [TestMethod]
        public void MoveLeft_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s.MoveLeft();
            Assert.AreEqual(new Point(3, 0), s[0].Position);
        }
        [TestMethod]
        public void MoveLeft_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s[0].Position = new Point(0, 0);
            s[1].Position = new Point(1, 0);
            s[2].Position = new Point(1, 1);
            s[3].Position = new Point(2, 1);
            s.MoveLeft();
            Assert.AreEqual(new Point(0, 0), s[0].Position);
        }
        [TestMethod]
        public void MoveRight_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s.MoveRight();
            Assert.AreEqual(new Point(5, 0), s[0].Position);
        }
        [TestMethod]
        public void MoveRight_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s[0].Position = new Point(7, 0);
            s[1].Position = new Point(8, 0);
            s[2].Position = new Point(8, 1);
            s[3].Position = new Point(9, 1);
            s.MoveRight();
            Assert.AreEqual(new Point(7, 0), s[0].Position);
        }
        [TestMethod]
        public void MoveDown_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s.MoveDown();
            Assert.AreEqual(new Point(4, 1), s[0].Position);
        }
        [TestMethod]
        public void MoveDown_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s[0].Position = new Point(4, 18);
            s[1].Position = new Point(5, 18);
            s[2].Position = new Point(5, 19);
            s[3].Position = new Point(6, 19);
            s.MoveDown();
            Assert.AreEqual(new Point(4, 18), s[0].Position);
        }
        [TestMethod]
        public void Drop_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s.Drop();
            Assert.AreEqual(new Point(4, 18), s[0].Position);
        }
        [TestMethod]
        public void Drop_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s[0].Position = new Point(4, 18);
            s[1].Position = new Point(5, 18);
            s[2].Position = new Point(5, 19);
            s[3].Position = new Point(6, 19);
            s.Drop();
            Assert.AreEqual(new Point(4, 18), s[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpaceFirstTime()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s.MoveDown();
            s.MoveDown();
            s.Rotate();
            Assert.AreEqual(new Point(3, 1), s[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpaceSecondTime()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s.MoveDown();
            s.MoveDown();
            s.Rotate();
            s.Rotate();
            Assert.AreEqual(new Point(4, 2), s[0].Position);
        }
        [TestMethod]
        public void Rotate_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s.Rotate();
            Assert.AreEqual(new Point(4, 0), s[0].Position);
        }
        [TestMethod]
        public void Reset_RegularUsage()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeZ(b);
            s[0].Position = new Point(4, 18);
            s[1].Position = new Point(5, 18);
            s[2].Position = new Point(5, 19);
            s[3].Position = new Point(6, 19);
            s.Reset();
            Assert.AreEqual(new Point(4, 0), s[0].Position);
        }
    }
}
