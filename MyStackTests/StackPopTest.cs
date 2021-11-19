using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack.ForTests;
using System;

namespace MyStackTests
{
    [TestClass]
    public class StackPopTest
    {
        [TestMethod]
        public void StackPopValueIsReturnTest()
        {
            // Arrange
            object startValue = 100;

            // Act
            StackForPopTest test = new StackForPopTest(startValue);

            object endValue = test.Pop();

            // Assert
            Assert.AreEqual(startValue, endValue);
        }
    }
}
