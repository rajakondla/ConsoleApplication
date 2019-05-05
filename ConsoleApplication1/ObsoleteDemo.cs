using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ObsoleteDemo
    {
        [Obsolete("Use MyMethod2")]
        static int MyMethod(int a, int b)
        {
            return a / b;
        }
        //improved version of MyMethod
        static int MyMethod2(int a, int b)
        {
            return b == 0 ? 0 : a / b;
        }
        static void Main()
        {
            //Console.WriteLine("The result is:", MyMethod(5, 0));
            Console.WriteLine("The result is:" +MyMethod2(5, 4));
        }
    }
}
