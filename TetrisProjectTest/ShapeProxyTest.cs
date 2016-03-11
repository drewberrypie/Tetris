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
        public void OnJoinPile_EventIsRaised()
        {
            //Assemble
            Board b = new Board();
            IShape s = b.Shape;
            List<string> receivedEvents = new List<string>();
            s.JoinPile += delegate(IShape shape)
            {
                receivedEvents.Add("test true");
            };
            //Act
            s.Drop();
            //Assert


        }
    }
}
