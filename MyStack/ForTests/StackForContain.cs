using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack.ForTests
{
    public class StackForContain : Stack
    {
        private object[] _testValue;

        public StackForContain(object[] testValue)
        {
            _testValue = testValue;
        }

        public override object Contain(object find)
        {
            for (int i = _testValue.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{_testValue[i]} = {find}");
                if (Convert.ToString(_testValue[i]) == Convert.ToString(find))
                {
                    return true;
                }
            }
            return false;
        }
        public object[] Return()
        {
            return _testValue;
        }
    }
}
