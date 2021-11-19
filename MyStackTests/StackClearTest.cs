using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack.ForTests;
using System;

namespace MyStackTests
{
    [TestClass]
    public class StackClearTest
    {
        [TestMethod]
        public void SrackClearArrayTest()
        {
            // Arrange
            object[] startValue = {1,"das", 3.44 ,4 ,522 };

            // Act
            StackForClearTest test = new StackForClearTest(startValue);

            test.Clear();

            object[] endValue = test.Return();

            // Assert
            for (int i = 0; i < endValue.Length; i++)
            {
                Assert.IsNull(endValue[i]);
            }
            
            //Assert.IsInstanceOfType(endValue, typeof(long));
        }
    }
}
