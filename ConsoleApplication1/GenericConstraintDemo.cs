using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ArrayUtils<T> where T : IComparable
    {
        T[] values;
        public void Insert(T[] values)
        {
            this.values = values;
        }
        public void Print()
        {
            foreach (T v in values)
                Console.WriteLine(v);
        }
        public void Sort()
        {
            Console.WriteLine("After sorting values we get:");
            Array.Sort(values);
            foreach (T sv in values)
                Console.WriteLine(sv);
        }
        public int CompareTo(T v)
        {
            for (int i = 0; i < values.Length; i++)
                if (values[i].CompareTo(v) == 0)
                    return i;
            return -1;
        }
    }
    class GenericConstraintDemo
    {
        static void Main()
        {
            ArrayUtils<int> au = new ArrayUtils<int>();
            int[] num = { 10, 30, 45, 23, 56, 78 };
            au.Insert(num);
            au.Print();
            au.Sort();
            Console.WriteLine("number found at {0} position ", au.CompareTo(20));
        }
    }
}
