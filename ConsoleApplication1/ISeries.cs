using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ArrayUtil
    {
        public static void Fill<T>(T[] value)
       {
           for(int i=0;i<value.Length;i++)
               value[i]=default(T);
       }
        public static void Print<T>(T[] value)
        {
            foreach(T v in value)
                Console.WriteLine(v);
        }
    }
    class GenericArrayUtil
    {
        static void Main()
        {
            int[] a = { 34, 67, 56, 45, 23, 12, 43, 23 };
            ArrayUtil.Print<int>(a);
            ArrayUtil.Fill<int>(a);

            double[] da = { 34.5, 67.56, 32.56, 12.5 };
            ArrayUtil.Print(da);
        }
    }
}
