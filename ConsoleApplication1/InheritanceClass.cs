using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class InheritanceClass
    {
        static void Main()
        {
            A a = new A();
            B b = new B();
            a = b;
            a.Print();
        }
    }

    class A
    {
        public int b = 1;
        public virtual void Print()
        {
            Console.WriteLine("A()");
        }
    }
    class B : A
    {
        public int i = 1;
        public override void Print()
        {
            Console.WriteLine("B()");
        }
    }
}
