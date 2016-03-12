using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TetrisProject;
using System.Collections.Generic;

namespace TetrisProjectTest
{
    [TestClass]
    public class ShapeProxyTest
    {
        [TestMethod]
        public void Shape_ConstructedCorrectly()
        {
            Board b = new Board();
            Shape s = new ShapeT(b);
        }
        [TestMethod]
        public void DeployNewShape_NotNull()
        {
            Board b = new Board();
            ShapeProxy s = new ShapeProxy(b);
            s.DeployNewShape();
            Assert.IsNotNull(s);
        }
    }
}