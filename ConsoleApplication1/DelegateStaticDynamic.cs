using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    delegate int Add(int a,int b);
    class DelegateStaticDynamic
    {
        static void Main()
        {
            Add add=Addition;
            Console.WriteLine(add(5, 7));
        }

        static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
