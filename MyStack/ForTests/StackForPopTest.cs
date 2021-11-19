using System;


namespace MyStack.ForTests
{
    public class StackForPopTest : Stack
    {
        private object _testValue;

        public StackForPopTest(object testValue)
        {
            _testValue = testValue;
        }

        public override object Pop()
        {
            if (Count < 0)
            {
                Console.WriteLine("Stack Underflow\n");
                return 0;
            }
            else
            {
                object value = _testValue;
                stack[Count--] = 0;
                return value;
            }
        }
    }
}
