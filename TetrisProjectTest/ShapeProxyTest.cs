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
        [TestMethod]
        public void OnJoinPile_EventIsRaised()
        {
            //Assemble
            Board b = new Board();
            Console.WriteLine(b.ToString());
            IShape s = null;
            try {
                Console.WriteLine("Try block: "+b.Shape);
                s = b.Shape;
            } catch (NullReferenceException e)
            {
                Console.WriteLine("b.Shape exception");
            }
            Console.WriteLine(s.ToString());
            List<string> receivedEvents = new List<string>();
            
            s.JoinPile += delegate(IShape shape)
            {
                receivedEvents.Add("test true");
            };
            //Act
            s.Drop();
            //Assert
            Assert.AreEqual(1, receivedEvents.Count);
            Assert.AreEqual("test true", receivedEvents[0]);
        }
    }
}
