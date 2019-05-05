#define FullVersion


using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class ConditionalAttributeDemo
    {
        [Conditional("Trial")]
        static void Trial()
        {
            Console.WriteLine("This is trial version");
        }
        [Conditional("FullVersion")]
        static void FullVersion()
        {
            Console.WriteLine("This is full version");
        }
        static void Main()
        {
            Trial();
            FullVersion();
        }
    }
}
