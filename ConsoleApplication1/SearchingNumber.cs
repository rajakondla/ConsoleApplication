using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class SearchingNumber
    {
        static void Main()
        {
            int[] num = { 10, 34, 21, 45, 35, 67 };
            int snum = 34;
            int[] dnum = { 90, 67 };
            dnum.CopyTo(num, 3);
            foreach (int f in num)
                Console.WriteLine(f);
            Console.WriteLine("----------------------------------");
            Array.Reverse(num);
            foreach (int f in num)
                Console.WriteLine(f);
            Console.WriteLine("--------------------------");
            int[] rf=Array.FindAll(num, item=>item>20);
            Console.WriteLine("--------------------------");
            foreach(int e in rf)
            Console.WriteLine(e);
            int rbs = Array.BinarySearch(num, snum);
            Console.WriteLine("number found in array");
        }
    }
}
