using System;
using System.Reflection;

namespace ConsoleApplication1
{
    class AssemblyInformationDemo
    {
        static void Main()
        {
            Assembly ass;
            Console.WriteLine("Enter an assembly");
            //string path = Console.ReadLine();
            // ass=Assembly.LoadFile(path);
            ass = Assembly.GetExecutingAssembly();
            Console.WriteLine("Assembly name is:"+ass.FullName);
            foreach (Type t in ass.GetTypes())
            {
                string typename = "class";
                if (t.IsValueType)
                    typename = "struct";
                if (t.IsInterface)
                    typename = "Interface";
                Console.WriteLine("{0}-{1}", t.Name, typename);
            }
        }
    }
}
