using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    enum Days{Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
    class EnumDemo
    {
        static void Main()
        {
            Days day = Days.Monday;
            Console.WriteLine(day);
        }
    }
}
