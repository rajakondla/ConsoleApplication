using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AnonymousMethod
    {
        public delegate int Mul(int i,int j);
        static void Main()
        {
            int[] s = { 9, 10, 11, 12 };
            Mul value = delegate(int i,int j)
                      {
                          return i * j;
                      };
            Console.WriteLine(value(s[0],s[2]));

            int[] values = Array.FindAll(s, n => n > 9);
            foreach (int get in values)
                Console.WriteLine(get);
        }
    }


    class Async
    {
        public async Task ThreadSleep()
        {
            Console.WriteLine("Thread sleep started");
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Thread {0}", i);
            }
            Console.WriteLine("Thread wake up"); ;
        }

        public async Task Print()
        {
            Console.WriteLine("Print started");
            for (int i=0;i<1000;i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Print {0}",i);
            }
        }

        public async Task CommonCall()
        {
            Task task1 = ThreadSleep();
            Task task2 = Print();
            await Task.WhenAll(task1, task2);
        }

        static void Main()
        {
            Async asyncObj = new Async();
            Task task=asyncObj.Print();
            Task task1 = asyncObj.ThreadSleep();
            // asyncObj.Print();
            //tasks[0].Start();
            //tasks[1].Start();

            for (int i=0;i<100; i++)
            Console.WriteLine("calling from main method {0}",i);

            task.Wait();
            task1.Wait();
           // task2.Wait();

            Console.WriteLine("----------End-----------");
            Console.ReadKey();
        }
    }
}
