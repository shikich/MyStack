using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack.ForTests;
using System;

namespace MyStackTests
{
    [TestClass]
    public class StackPopLongTest
    {
        [TestMethod]
        public void StackIsLongValueReturnTest()
        {
            // Arrange
            long startValue = 9_223_372_036_854_775_807;

            // Act
            StackForPopTest test = new StackForPopTest(startValue);

            long endValue = (long)test.Pop();

            // Assert
            Assert.AreEqual(startValue, endValue);
            Assert.IsInstanceOfType(endValue, typeof(long));
        }
    }
}
