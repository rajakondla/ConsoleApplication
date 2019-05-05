using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class TestinterfaceMain
    {
         static int x;
         static void Main()
        {
            Console.Write("Enter a number:");
            x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                Console.WriteLine(x);
            else
               Console.WriteLine(0);
        }
    }
}
