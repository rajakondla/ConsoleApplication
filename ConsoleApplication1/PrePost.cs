using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PrePost
    {
        int _result = 100; int q = 100; int r = 100;
        static void Main()
        {
           // 
            PrePost obj = new PrePost();
            //obj.p = (obj.q++) + (--obj.r);
            Console.WriteLine(obj.q++);
            Console.WriteLine(obj.q);
          //  Console.WriteLine(obj.p);
        
            Console.Read();
        }
    }
}
