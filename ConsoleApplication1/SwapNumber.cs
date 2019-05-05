using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public delegate void swap(out int a,out int b);
    class SwapNumber
    {
        static void Main()
        {
            int f;
            int s;
            SwapNumber sw1 = new SwapNumber();
            //swap  sw.Swap(out f,out s);
            swap sw = sw1.Swap;
            sw(out f, out s);
            Console.WriteLine("f:{0},s:{1}", f, s);
        }
        public void Swap(out int a,out int b)
        {
            //a = a + b;
            //b = a - b;
            //a = a - b;

            //b=a => b=77
            //
            a = 22; b = 56;
            a = (b - a) + (b = a);
        }
    }
}
