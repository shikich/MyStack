using System;

namespace MyStack.ForTests
{
    public class StackForPushTest : Stack
    {
        public override bool Push(object data)
        {
            if (Count >= MAX)
            {
                return false;
            }
            else
            {
                stack[++Count] = data;
                return true;
            }
        }
    }
}
