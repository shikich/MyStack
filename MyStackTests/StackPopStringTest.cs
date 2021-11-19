using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack.ForTests;
using System;

namespace MyStackTests
{
    [TestClass]
    public class StackPopStringTest
    {
        [TestMethod]
        public void StackIsSrtingValueReturnTest()
        {
            // Arrange
            string startValue = "I'm a value";

            // Act
            StackForPopTest test = new StackForPopTest(startValue);

            string endValue = (string)test.Pop();

            // Assert
            Assert.AreEqual(startValue, endValue);
            Assert.IsInstanceOfType(endValue, typeof(string));
        }
    }
}
