using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Exp1
    {
        static void Main()
        {
            int[] num = {1,3,2,4};
            var get = from a in num
                         where a < 3
                         orderby a
                         select a;
            foreach (int getNum in get)
                Console.WriteLine(getNum);
        }
    }
    class Exp2
    {
        static void Main()
        {
            int[] num = { 1, 3, 2, 4 };
            var get = num.Sum();
            Console.WriteLine(get);
        }
    }
}
