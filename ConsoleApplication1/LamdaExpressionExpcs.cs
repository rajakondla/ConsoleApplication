using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LamdaExpressionExpcs
    {
        int[] a = { 2,5,4,11,12,14,16,12,18};
        public static void Main()
        {
            LamdaExpressionExpcs lmd = new LamdaExpressionExpcs();
            int[] result = Array.FindAll(lmd.a, n => n % 2 == 0);
            for (int i = 0; i < result.Length; i++) 
            Console.WriteLine(result[i]);

            for (int i = 0, j = 1; i < 10; j++, i++)
            {
                Console.WriteLine("{0},{1}", i, j);
            }

            Console.WriteLine("---------------------------------");

            double k = 2.0;
            for (int i = 0; i < 10; k++, i++)
            {
                Console.WriteLine("{0},{1}", i, k);
            }

            int[] result1 = Array.FindAll(lmd.a, delegate(int v)
                                                 {
                                                     // only a boolean check is done here and returns true or false
                                                     // to do the calculation of any variables using anonymous method then use delegate with anonymous method example [AnonymousMethod.cs]
                                                     return v % 2 == 0;
                                                 }
                                         );
            foreach (int i in result1)
                Console.WriteLine(i);
        }
        public static int Even(int n)
        {
            return n % 2 == 0 ? n : -1;
        }
    }
}
