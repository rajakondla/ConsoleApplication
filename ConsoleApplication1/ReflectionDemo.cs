using System;
using System.Reflection;
namespace ConsoleApplication1
{
    class ReflectionDemo
    {
        static void Main()
        {
            Type t = Type.GetType("System.DateTime");
            Console.WriteLine(t.Name);
            Console.WriteLine(t.FullName);
            Console.WriteLine("Properties");
            Console.WriteLine("=============");
            foreach (PropertyInfo pi in t.GetProperties()) 
            Console.WriteLine(pi.Name+":"+pi.PropertyType.Name);
            Console.WriteLine("Methods");
            Console.WriteLine("========");
            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine(mi.Name + ":" + mi.MemberType+":");
                Console.WriteLine("Parameters");
                Console.WriteLine("==========");
                foreach (ParameterInfo pi in mi.GetParameters())
                    Console.WriteLine(pi.Name + ":" + pi.ParameterType.Name);
            }
            Console.WriteLine();
        }
    }
}
