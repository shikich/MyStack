using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack.ForTests;
using System;

namespace MyStackTests
{
    [TestClass]
    public class StackContainTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            object[] startValue = { 1, 3.14, "space", 100010};
            object toFind = 3.14;

            // Act            
            StackForContain test = new StackForContain(startValue);
            bool result = (bool)test.Contain(toFind);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
