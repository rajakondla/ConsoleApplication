using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class TupleDemo
    {
        static void Main()
        {
            var t1 = Tuple.Create(1, "Raja Kondla", "rajakondla@gmail.com");
            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item2);
            Console.WriteLine(t1.Item3);
            var t2 = Tuple.Create(1, 2, 3, 4, 5, 6,Tuple.Create(7, 8, Tuple.Create(10, 11)));
            Console.WriteLine(t2.Item1);
            Console.WriteLine(t2.Item7.Item1);
            Console.WriteLine(t2.Item7.Item3.Item2);
            var t3 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine(t3.Rest);
            Tuple<string, double> book = Tuple.Create("C# complete reference", 600.00);
            PrintBook(book.Item1, book.Item2);
        }
        public static void PrintBook(string name, double rate)
        {
            Console.WriteLine("Book name:{0}, rate:{1}", name, rate);
            Console.WriteLine("{0:F2}", rate);
        }
    }
}
