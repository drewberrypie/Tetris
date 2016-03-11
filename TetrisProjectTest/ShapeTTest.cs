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
            Shape s = new ShapeT(b);
            //Assert
            Assert.IsInstanceOfType(s, typeof(ShapeT));
        }
        [TestMethod]
        public void MoveLeft_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            //Act
            s.MoveLeft();
            //Assert
            Assert.AreEqual(new Point(3, 0), s[0].Position);
        }
        [TestMethod]
        public void MoveLeft_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            s[0].Position = new Point(0, 0);
            s[1].Position = new Point(1, 0);
            s[2].Position = new Point(2, 0);
            s[3].Position = new Point(1, 1);
            //Act
            s.MoveLeft();
            //Assert
            Assert.AreEqual(new Point(0, 0), s[0].Position);
        }
        [TestMethod]
        public void MoveRight_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            //Act
            s.MoveRight();
            //Assert
            Assert.AreEqual(new Point(5, 0), s[0].Position);
        }
        [TestMethod]
        public void MoveRight_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            s[0].Position = new Point(8, 0);
            s[1].Position = new Point(9, 0);
            s[2].Position = new Point(10, 0);
            s[3].Position = new Point(9, 1);
            //Act
            s.MoveRight();
            //Assert
            Assert.AreEqual(new Point(8, 0), s[0].Position);
        }
        [TestMethod]
        public void MoveDown_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            //Act
            s.MoveDown();
            //Assert
            Assert.AreEqual(new Point(4, 1), s[0].Position);
        }
        [TestMethod]
        public void MoveDown_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            s[0].Position = new Point(4, 19);
            s[1].Position = new Point(5, 19);
            s[2].Position = new Point(6, 19);
            s[3].Position = new Point(5, 20);
            //Act
            s.MoveDown();
            //Assert
            Assert.AreEqual(new Point(4, 19), s[0].Position);
        }
        [TestMethod]
        public void Drop_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            //Act
            s.Drop();
            //Assert
            Assert.AreEqual(new Point(4, 18), s[0].Position);
        }
        [TestMethod]
        public void Drop_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            s[0].Position = new Point(4, 19);
            s[1].Position = new Point(5, 19);
            s[2].Position = new Point(6, 19);
            s[3].Position = new Point(5, 20);
            //Act
            s.Drop();
            //Assert
            Assert.AreEqual(new Point(4, 19), s[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpaceFirstTime()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            s.MoveDown();
            //Act
            s.Rotate();
            //Assert
            Assert.AreEqual(new Point(5, 2), s[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpaceSecondTime()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            s.MoveDown();
            s.Rotate();
            //Act
            s.Rotate();
            //Assert
            Assert.AreEqual(new Point(6, 1), s[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpaceThirdTime()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            s.MoveDown();
            //Act
            s.Rotate();
            s.Rotate();
            s.Rotate();
            //Assert
            Assert.AreEqual(new Point(5, 0), s[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpacLastTime()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            s.MoveDown();
            s.Rotate();
            s.Rotate();
            s.Rotate();
            //Act
            s.Rotate();
            //Assert
            Assert.AreEqual(new Point(4, 1), s[0].Position);
        }
        [TestMethod]
        public void Rotate_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            //Act
            s.Rotate();
            //Assert
            Assert.AreEqual(new Point(4, 0), s[0].Position);
        }
        [TestMethod]
        public void Reset_PositionReset()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeT(b);
            s[0].Position = new Point(4, 18);
            s[1].Position = new Point(5, 18);
            s[2].Position = new Point(6, 18);
            s[3].Position = new Point(5, 19);
            //Act
            s.Reset();
            //Assert
            Assert.AreEqual(new Point(4, 0), s[0].Position);
        }
    }
}
