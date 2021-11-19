using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack.ForTests;
using System;

namespace MyStackTests
{
    [TestClass]
    public class StackPushNPopTest
    {
        [TestMethod]
        public void StackPush_CreateNPop_DeleteTest()
        {
            // Arrange
            object[] startArray = new object[5];

            // Act
            StackForPushNPopTest test = new StackForPushNPopTest(startArray);
            test.Push("first");

            test.Pop();

            object[] endArray = test.Return();

            // Assert
            for(int i = 0; i < endArray.Length; i++)
            {
                Assert.IsNull(endArray[i]);
            }
        }
    }
}
