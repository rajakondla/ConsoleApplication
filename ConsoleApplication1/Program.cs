using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
       public void Print()
        {
            Console.WriteLine("Hello Raja!");
        }
    }
    class TestProgram
    {
        static void Main()
        {
            Program p = new Program();
            p.Print();
        }
    }
}
