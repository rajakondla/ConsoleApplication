using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class AutoSetManualSet
    {
        private ManualResetEvent manReset = new ManualResetEvent(false);
        private AutoResetEvent autoReset = new AutoResetEvent(false);
        public void RunAll()
        {
            new Thread(Worker1).Start();
            new Thread(Worker2).Start();
            new Thread(Worker3).Start();



            manReset.Set();
            Thread.Sleep(1000);
            manReset.Reset();
            Console.WriteLine("Press to release all threads.");
            Console.ReadLine();
            manReset.Set();
        }

        public void Worker1()
        {
            Console.WriteLine("Entered in worker 1");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker1 is running {0}", i);
                Thread.Sleep(2000);
                manReset.WaitOne();
            }
        }
        public void Worker2()
        {
            Console.WriteLine("Entered in worker 2");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker2 is running {0}", i);
                Thread.Sleep(2000);
                manReset.WaitOne();
            }
        }
        public void Worker3()
        {
            Console.WriteLine("Entered in worker 3");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker3 is running {0}", i);
                Thread.Sleep(2000);
                manReset.WaitOne();
            }
        }
    }

    class TestAutoManual
    {
        static void Main()
        {
            AutoSetManualSet autoObj = new AutoSetManualSet();
            autoObj.RunAll();
        }
    }
}
