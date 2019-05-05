using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class factorial
    {
        public class NestedFactorial
        {
            public void Print()
            {
                Console.Write("Raja ");
            }
        }
        public NestedFactorial CreateObject()
        {
            NestedFactorial nf = new NestedFactorial();
            return nf;
        }
    }
    class GetFactorial
    {
        static void Print1()
        {
            Console.WriteLine("Kondla");
        }
        static void Main()
        {
            factorial f = new factorial();
            factorial.NestedFactorial nf = f.CreateObject();
            nf.Print();
            Print1();
        }
    }                                                                                  
}
