using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Threading
    {
        static void Main()
        {
            ThreadCreate obj = new ThreadCreate();
            obj.CallingMethod();
            Console.WriteLine("Third");
            //Task task1 = Task.Factory.StartNew(()=> { Thread.Sleep(5000); Console.WriteLine("Task1"); });
            //Task task2 = Task.Factory.StartNew(() => { Thread.Sleep(1000); Console.WriteLine("Task2"); });
            //Task task3 = Task.Factory.StartNew(() => { Thread.Sleep(500); Console.WriteLine("Task3"); });

            //Task.WaitAll(task1,task2,task3);

            //ThreadFactory threadFactory = new ThreadFactory();
            //CancellationTokenSource source = new CancellationTokenSource();
            //int k = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    int l = i;
            //    threadFactory.CreateThread(() => { Console.WriteLine("Thread number {" + l + "}"); Thread.Sleep(1000); });
            //}

            //Task.WaitAll(threadFactory.threads.ToArray());

            //Console.WriteLine("Main thread completed");
            Console.ReadKey();
        }

    }

    class ThreadFactory
    {
        public List<Task> threads = new List<Task>();
        
        public void CreateThread(Action action,string threadName="")
        {
            Task task = Task.Factory.StartNew(action);
            threads.Add(task);
         
        }
    }

    class ThreadCreate
    {
        public async Task CallingMethod()
        {
            await LongProcess();
            Console.WriteLine("Second");
        }

        private Task LongProcess()
        {
            return Task.Factory.StartNew(()=> { Thread.Sleep(5000); Console.WriteLine("First"); });
        }
    }
}
