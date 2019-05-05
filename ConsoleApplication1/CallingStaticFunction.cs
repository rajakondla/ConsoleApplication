using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class StaticClass
    {
        public static string str = SetValue("Variable declaration");
        public static string str1 = SetValue("Second Variable declaration");

        static StaticClass()
        {
            Console.WriteLine("Static constructor call: {0}", str);
        }

        //public StaticClass()
        //{
        //    str1 = "Raja";
        //    Console.WriteLine("Nomal variable {0}", str1);
        //    Console.WriteLine("Normal constructor call: {0}", str);
        //}

        public static string SetValue(string value)
        {
           // str = value;
            Console.WriteLine("Value of str is : {0}", value);
            return value;
        }

    }

    class TestStaticClass
    {
        static void Main()
        {
            //StaticClass obj = new StaticClass();
            Console.WriteLine("First line..");

            for(int i=0;i<100;i++)
            {
                Console.WriteLine("Initializer:{0}",i);
            }

            //   StaticClass obj = new StaticClass();
            //StaticClass.str = "";
            StaticClass.SetValue("Call from test static class");

            Console.WriteLine(StaticClass.str);

            Console.ReadKey();
        }
    }

    /*
     * static constructor will be called before normal constructor
     * if static constructor exists, then static fields are initialized when first called to any static fields or methods.
     * if no static constructor exists, then static fields are initialized when we create constructor object even we do not refer static fields
     * if both static constructor and normal constructor exists, 
     * then static fields are initialized when we create constructor object even we do not refer static fields
     */
}
