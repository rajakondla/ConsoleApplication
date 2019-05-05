using System;
using System.Threading;

namespace ConsoleApplication1
{
    class DemoThread
    {
        void CountUp()
        {
            Console.WriteLine("from thread 1---------------------------------:");
            for (int i = 0; i <= 10; i++)
                Console.WriteLine(i);

        }
        void CountDown()
        {
            Console.WriteLine("from thread 2---------------------------------:");
            for (int i = 10; i >= 0; i--)
                Console.WriteLine(i);
        }
        static void Main()
        {
        
            DemoThread dt = new DemoThread();

            Thread t1 = new Thread(new ThreadStart(dt.CountUp));
            Thread t2 = new Thread(dt.CountDown);
           
            t1.Start();
            //dt.CountUp();
            //string name = "Raja";
            //for (int i = name.Length - 1; i >= 0; i--)
            //    Console.WriteLine(name[i]);
            
            t2.Start();
            //dt.CountDown();
            

        }
    }
}
