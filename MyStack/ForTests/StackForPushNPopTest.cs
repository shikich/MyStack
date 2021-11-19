using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack.ForTests
{
    public class StackForPushNPopTest : Stack
    {
        private object[] _testValue;

        public StackForPushNPopTest(object[] testValue)
        {
            _testValue = testValue;
        }

        public override bool Push(object data)
        {
            if (_testValue.Length >= 5)
            {
                return false;
            }
            else
            {
                _testValue[++Count] = data;
                return true;
            }
        }

        public override object Pop()
        {
            if (_testValue.Length < 0)
            {
                Console.WriteLine("Stack Underflow\n");
                return 0;
            }
            else
            {
                object value = _testValue;
                _testValue[Count--] = null;
                return true;
            }
        }
        public object[] Return()
        {
            return _testValue;
        }
    }
}
