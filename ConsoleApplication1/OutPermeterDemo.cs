using System;

namespace ConsoleApplication1
{
    class OutPermeterDemo
    {
        public static void Main(string[] args)
        {
            var firstn = 0; var second = 0;
            firstn = Int32.Parse(Console.ReadLine());
            second = Int32.Parse(Console.ReadLine());
            var result = firstn + second;
            Console.WriteLine(result);
            Console.WriteLine();
         }  
    }
}
