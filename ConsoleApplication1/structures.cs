using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    struct Foo
    {
        public string x;
        public Foo(string x)
        {
            this.x = x;
        }
    }

    class FooTester
    {
        [STAThread]
        static void Main(string[] args)
        {
            Foo f = new Foo();
            Console.WriteLine(f.x);
        }
    }
}
