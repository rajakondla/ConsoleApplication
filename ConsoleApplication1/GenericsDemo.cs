using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class GenericStack<T> 
    {
        T[] a = new T[10];
        int top = 0;
        public void Push(T v)
        {
            a[top] = v;
            top++;
        }
        public T Pop()
        {
            top--;
            return a[top];
        }
        public int Length
        {
            get
            {
                return top;
            }
        }
    }
    class TestGenericStack
    {
        static void Main()
        {
            GenericStack<int> istack = new GenericStack<int>();
            istack.Push(10);
            istack.Push(20);
            Console.WriteLine("pushed value is:" + istack.Pop());
            Console.WriteLine("length is:" + istack.Length);
            GenericStack<string> strsteck = new GenericStack<string>();
            strsteck.Push("Raja");
            strsteck.Push("Kondla");
            Console.WriteLine("pushed value is:"+ strsteck.Pop());
            Console.WriteLine("length is:"+ strsteck.Length);
        }
    }
}
