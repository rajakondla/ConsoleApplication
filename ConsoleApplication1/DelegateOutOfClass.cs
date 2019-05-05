using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
   public delegate void SimpleDelegate();
   class TestDelegate
   {
       public static void Print()
       {
           Console.WriteLine("Hai! This is delegate");
       }


       static void Main()
       {
           SimpleDelegate sd = Print;
           sd();
       }
   }
}
