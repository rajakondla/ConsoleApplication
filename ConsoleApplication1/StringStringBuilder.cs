using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class StringStringBuilder
    {
        public static void Main()
        {
            //string foo = "foo";
            //StringBuilder sb = new StringBuilder("Raja");
            //Console.WriteLine("first sb value: " + sb);
            ////StringStringBuilder ssb = new StringStringBuilder();
            //string fromBuilder = sb.Insert(2, "aaa").ToString();
            //string fromString = foo.Replace("o", "a");
            //Console.WriteLine("foo: " + foo);
            //Console.WriteLine("fromString: " + fromString);
            //Console.WriteLine("after foo replaced: " + foo);
            //Console.WriteLine("ssb: " + sb.ToString());
            //Console.WriteLine("fromBuilder: " + fromBuilder);

            string fromString = "Raja";
            StringBuilder fromStringBuilder = new StringBuilder("Raja");
            Console.WriteLine("Actual string: " + fromString);
            Console.WriteLine("Actual string builder: " + fromStringBuilder);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("First fromString: " + fromString.Replace('j','k'));
            Console.WriteLine("First fromStringBuilder: " + fromStringBuilder.Replace('j','k'));
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Second fromString: " + fromString);
            Console.WriteLine("Second fromStringBuilder: " + fromStringBuilder);

        }
    }
}
