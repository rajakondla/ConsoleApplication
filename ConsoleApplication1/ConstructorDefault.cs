using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent...");
        }
        public void Print()
        {
            Console.WriteLine("I'm from parent");
        }
    }

    class ChildClass:ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Child...");
        }
        public static int Main()
        {
            ChildClass child = new ChildClass();
            return 1;
        }
    }
}
