using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack.ForTests;
using System;

namespace MyStackTests
{
    [TestClass]
    public class StackPushTest
    {
        [TestMethod]
        public void StackPushAwaitTrueTest()
        {
            // Arrange
            int x = 100;

            // Act
            StackForPushTest test = new StackForPushTest();

            bool result = test.Push(x);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
