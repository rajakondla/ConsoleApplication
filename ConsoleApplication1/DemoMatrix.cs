using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class DemoMatrix
    {
        public int rs = 0;
        public int cs = 0;
            
        public static void Main()
        {
            DemoMatrix dm = new DemoMatrix();
            Console.WriteLine("Enter max-rows");
            dm.rs = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Enter max-cols");
            dm.cs = Int16.Parse(Console.ReadLine());
            int[,] a=new int[dm.rs,dm.cs];

        }
        public void Print()
        {
            Console.WriteLine("dsfdsf");
        }
    }
}
