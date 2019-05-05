using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    enum values {Raja,Arun,Praveen,Srinu};
    class DemoDelegate
    {
        public delegate int MathDelegate(int a, int b);
        static void Main()
        {
            DemoDelegate dd = new DemoDelegate();
            MathDelegate d1 = new MathDelegate(Add);
            Console.WriteLine(d1(5, 4));
            Console.WriteLine("This output is from method group conversion");
            Console.WriteLine("===========================================");                             
            // method group conversion
            MathDelegate d2 = Add;
            Console.WriteLine(d2(5, 4));
            Console.WriteLine("===========================================");
            string[] getenum = (string[])Enum.GetNames(typeof(values));
            string[] getnames=Array.FindAll(getenum,new Predicate<string> (FindName));//second argument should be of type bool
            foreach (string names in getnames)
                Console.WriteLine(names);
            Console.WriteLine("This output is from method group conversion of Array");
            Console.WriteLine("====================================================");
            string[] getnames1 = Array.FindAll(getenum, FindName);
            foreach (string names in getnames1)
                Console.WriteLine(names);
            Console.WriteLine("This output is from Anonymous method");
            Console.WriteLine("====================================");
            string[] getnames2=Array.FindAll(getenum,delegate(string name)
                                                     {
                                                         return name.Length==4;
                                                     });
            foreach (string names in getnames2)
                Console.WriteLine(names);
            Console.WriteLine("This output is from lamda expression");
            Console.WriteLine("=====================================");
            string[] getnames3 = Array.FindAll(getenum, names => names.Length == 4);
            foreach (string names in getnames3)
                Console.WriteLine(names);
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static bool FindName(string name)
        {
            return name.Length == 4;
        }
    }
}
