using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TetrisProject;

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
    }
}
