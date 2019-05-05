using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class StopWatch
    {
        static void Main()
        {
            System.Diagnostics.Stopwatch sObj = System.Diagnostics.Stopwatch.StartNew();
            System.IO.File.WriteAllText("timertest.txt", new string('*', 30000000));
            Console.WriteLine(sObj.Elapsed); // 00:00:01.4322661
        }
    }
}
