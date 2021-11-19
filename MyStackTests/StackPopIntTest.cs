using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack.ForTests;
using System;

namespace MyStackTests
{
    [TestClass]
    public class StackPopIntTest
    {
        [TestMethod]
        public void StackIsIntValueReturnTest()
        {
            // Arrange
            int startValue = 2_147_483_647;

            // Act
            StackForPopTest test = new StackForPopTest(startValue);

            int endValue = (int)test.Pop();

            // Assert
            Assert.AreEqual(startValue, endValue);
            Assert.IsInstanceOfType(endValue, typeof(int));
        }
    }
}
