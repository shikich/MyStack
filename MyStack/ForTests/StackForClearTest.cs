using System;

namespace MyStack.ForTests
{
    public class StackForClearTest : Stack
    {
        private object[] _testValue;

        public StackForClearTest(object[] testValue)
        {
            _testValue = testValue;
        }

        public override void Clear()
        {
            for (int i = _testValue.Length-1; i >= 0; i--)
            {
                _testValue[i] = null;
            }
            
            Count = 0;
            Console.WriteLine("Clear finished\n");
        }
        public object[] Return()
        {
            return _testValue;
        }
    }
}
