using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    abstract class AbstractDemo
    {
        public abstract int this[int index]
        {
            get;
            set;
        }
    }

    class Concrete : AbstractDemo
    {
        public override int this[int index]
        {
            get
            {
                Console.Write(" GET");
                return 10;
            }
            set
            {
                Console.Write(" SET");
            }
        }
    }

    class MyClient
    {
        public static void Main()
        {
            System.Diagnostics.Stopwatch sObj = System.Diagnostics.Stopwatch.StartNew();
            //System.IO.File.WriteAllText("timertest.txt", new string('*', 30000000));
            //System.IO.File.WriteAllText("timertest.txt", new string('*', 30000000));
            Console.WriteLine(sObj.Elapsed); // 00:00:01.4322661
            Console.WriteLine(sObj.ElapsedMilliseconds);
            Console.WriteLine(sObj.ElapsedTicks);
            Concrete c1 = new Concrete();
            c1[0] = 10;
            Console.WriteLine(c1[0]);//Displays 'SET GET 10'
        }
    }
 
}
