using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class TestReference
    {
        string name = "";
        static void Main()
        {
            TestReference A = new TestReference();
            TestReference B = new TestReference();
            TestReference C = new TestReference();
            A.name = "AAA";
            C = A;
            Console.WriteLine(C.name);
            A.name = "BBB";
            Console.WriteLine(C.name);
            B.name = "CCC";
            A = B;
            Console.WriteLine(A.name);
            Console.WriteLine(C.name);
            StringBuilder sb = new StringBuilder("Raj");
            StringBuilder sb1 = new StringBuilder("Khan");
            sb = sb1;
            Console.WriteLine(sb);
            sb1.Remove(1, 2);
            Console.WriteLine(sb);
          /*  string is reference type but really special one. When you do operation of both
           *  string values like in your example
              C = A, there is nothing in this operation simular to normal class behavior.
           * So C doesn't have a reference of A. In that operation, a new string class is created
           * and the value from string A is copied to string C. String C and String A are 
           * pointing in completly different memory address.
           * That is way, when you have many string operation, for example loop and in 
           * every iteration you have a string manipulation, because of new string class generation,
           * that operation is performance leak. In that situation it is preffered to use StringBuilder.
           * Why, because StringBuilder doesn't create new string for any string operation.
             Now for question, why string is not value type and it's reference type.
             When you have let's say int value, Int type has defined lenght and that is 4 byte.
           * And for every value type you know the exact memory space that will take. 
           * But for string you don't know that. It will be stupid to have a string type in wich
           * you should always define how long it is. And if you want to put in that string
           * variable a value with bigger lenght that string is defined, that will be disallowed.
             Why is string a special class. It is special because you have a reference class,
           * but the way of using it, looks like a value type. So, that's why you do operation like:
             string C = A, and not string C = new string(A);
             You don't have to instance string class because .NET framework do that for you when
           * you first time set it's value. If you not set it's value string has value of null 
           * like any other reference type. Every language platform has a special treatment for 
           * string type. .NET is not exclusion from that too. */




            //StringBuilder sb = new StringBuilder("RajaK");
            //string str = "RajaK";
            //string str1 = str.Replace('a', 'k');
            //string strsb = sb.Replace('a', 'k').ToString();
            //Console.WriteLine("sb:"+sb.ToString());
            //Console.WriteLine("str:" + str);
            //Console.WriteLine("str rep:" + str1);
            //Console.WriteLine("sb rep:" + strsb);
        }
    }
}
