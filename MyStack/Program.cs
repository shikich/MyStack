using System;


namespace MyStack
{
    static class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack(); 
            long longNumber = 9_223_372_036_854_775_807;

            //Push
            myStack.Push("house");
            myStack.Push(longNumber);
            myStack.Push(30);
            myStack.Push(40);

            myStack.PrintStack();
            myStack.Peek();

            Console.WriteLine("Item popped from Stack : {0}\n", myStack.Pop());
            myStack.PrintStack();

            myStack.Push(123);

            Console.WriteLine($"Is Stack contain ? - " + myStack.Contain(longNumber));

            //Pop
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();

            Console.WriteLine("Clearing...");
            myStack.Clear();

            myStack.PrintStack();

            Console.WriteLine("Is array an empty? - " + myStack.IsEmpty());
            Console.WriteLine("Array's length - " + myStack.Count);
            Console.ReadKey();
        }
    }

    public class Stack
    {
        internal static int MAX = 50;
        public int Count;
        internal object[] stack = new object[MAX];

        //IsEmpty method
        internal bool IsEmpty()
        {
            if (Count < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Push method
        public virtual bool Push(object data)
        {
            if (Count >= MAX)
            {
                Console.WriteLine("Stack Overflow\n");
                return false;
            }
            else
            {
                stack[++Count] = data;
                return true;
            }
        }   

        //Pop method
        public virtual object Pop()
        {
            if (Count < 0)
            {
                Console.WriteLine("Stack Underflow\n");
                return 0;
            }
            else
            {
                object value = stack[Count];
                stack[Count--] = null;
                return value;
            }
        }

        //Contain method
        public virtual object Contain(object find)
        {
            for (int i = Count; i >= 0; i--)
            {
                Console.WriteLine($"{stack[i]} = {find}");
                if(Convert.ToString(stack[i]) == Convert.ToString(find))
                {                   
                    return true;
                }
            }
            return false;
        }

        //Clear method
        public virtual void Clear()
        {
            for (int i = Count; i >= 0; i--)
            {
                stack[i] = null;
            }
            Count = 0;
            Console.WriteLine("Clear finished\n");
        }

        //Peek method
        internal void Peek()
        {
            if (Count < 0)
            {
                Console.WriteLine("Stack Underflow\n");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}\n", stack[Count]);
        }

        //Output stack method
        internal void PrintStack()
        {
            if (Count < 0)
            {
                Console.WriteLine("Stack Underflow\n");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");

                for (int i = Count; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
