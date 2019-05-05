using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class UnSafe_or_Unmanaged
    {
        static void Main()
        {
            PointerTest test = new PointerTest();
            unsafe
            {
                int* pi;
                fixed (int* px = &test.a)
                {
                    *px = 100;
                    pi = px;
                    
                }
                Console.WriteLine("before: " + *pi);
                Console.WriteLine(((int)&pi));
                GC.Collect(1);
                Console.WriteLine("after: " + *pi);
                Console.ReadLine();
            }
        }
    }

    class PointerTest
    {
       public int a = 1;
    }

    class Pointer2
    {
        static void Main()
        {
            unsafe
            {
                int* a;
                int b = 10;
                a = &b;
                Console.WriteLine("address of b is {0}", (int)&b);
                Console.WriteLine("address of b from a {0}", (int)a);
                Console.WriteLine("address of b from a {0}", (int)&a);
            }
        }
    }
}
