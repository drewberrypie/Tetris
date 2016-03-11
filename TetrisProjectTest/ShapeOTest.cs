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
            Shape s = new ShapeO(b);
            //Assert
            Assert.IsInstanceOfType(s, typeof(ShapeO));
        }
        [TestMethod]
        public void MoveLeft_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeO(b);
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
            Shape s = new ShapeO(b);
            s[0].Position = new Point(0, 0);
            s[1].Position = new Point(1, 0);
            s[2].Position = new Point(0, 1);
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
            Shape s = new ShapeO(b);
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
            Shape s = new ShapeO(b);
            s[0].Position = new Point(9, 0);
            s[1].Position = new Point(10, 0);
            s[2].Position = new Point(9, 1);
            s[3].Position = new Point(10, 1);
            //Act
            s.MoveRight();
            //Assert
            Assert.AreEqual(new Point(9, 0), s[0].Position);
        }
        [TestMethod]
        public void MoveDown_EnoughSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeO(b);
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
            Shape s = new ShapeO(b);
            s[0].Position = new Point(4, 19);
            s[1].Position = new Point(5, 19);
            s[2].Position = new Point(4, 20);
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
            Shape s = new ShapeO(b);
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
            Shape s = new ShapeO(b);
            s[0].Position = new Point(4, 19);
            s[1].Position = new Point(5, 19);
            s[2].Position = new Point(4, 20);
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
            Shape s = new ShapeO(b);
            //Act
            s.Rotate();
            //Assert
            Assert.AreEqual(new Point(4, 0), s[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpaceSecondTime()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeO(b);
            s.Rotate();
            //Act
            s.Rotate();
            //Assert
            Assert.AreEqual(new Point(4, 0), s[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpaceThirdTime()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeO(b);
            s.Rotate();
            s.Rotate();
            //Act
            s.Rotate();
            //Assert
            Assert.AreEqual(new Point(4, 0), s[0].Position);
        }
        [TestMethod]
        public void Rotate_EnoughSpacLastTime()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeO(b);
            s.Rotate();
            s.Rotate();
            s.Rotate();
            //Act
            s.Rotate();
            //Assert
            Assert.AreEqual(new Point(4, 0), s[0].Position);
        }
        [TestMethod]
        public void Rotate_NoSpace()
        {
            //Assemble
            Board b = new Board();
            Shape s = new ShapeO(b);
            //Act
            s.Rotate();
            //Assert
            Assert.AreEqual(new Point(4, 0), s[0].Position);
        }
    }
}
