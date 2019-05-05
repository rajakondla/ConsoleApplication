using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class FuncDelegate
    {
        public delegate bool greater3(int num);
        static void Main()
        {
            //And with C# 3.5, we got this new thing called Func<(T, TResult> Generic Delegate.
            //As per the documentation – “[Func] Encapsulates a method that has one parameter
            //and returns a value of the type specified by the TResult parameter”. First, 
            //it looked like a keyword. But it is a .NET generic delegate.

            // In Func input parameters all except last one.
            
            Func<int, bool> greaterThan3 = delegate(int num)
            {
                return (num > 3) ? true : false;
            };
            Console.WriteLine(greaterThan3(4));
                                              // input // definition
            Func<int, bool> greaterThanLamda3 = num => num > 3 ? true : false;
            Console.WriteLine(greaterThanLamda3(4));

            Func<int, bool> greaterThanLamda4 = (int num) => num > 3 ? true : false;
            Console.WriteLine(greaterThanLamda4(4));

            Func<int, int, int, int> Sum = (int a, int b, int c) => a + b + c;
            Console.WriteLine(Sum(4,5,6));
            Func<int, int, int, int> Sum1 = (a, b, c) => a + b + c;
            Console.WriteLine(Sum1(4, 5, 6));

            greater3 greaterDee = greater;
            Console.WriteLine(greaterDee(4));

        }

        public static bool greater(int num)
        {
            return num > 3 ? true : false;
        }
    }
}
