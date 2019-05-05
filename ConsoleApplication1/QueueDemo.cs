using System;
using System.Collections;

namespace ConsoleApplication1
{
    class QueueDemo
    {
        static void Main()
        {
            Queue que = new Queue(4,2);
            que.Enqueue("Raja");
            que.Enqueue("Praveen");
            que.Enqueue("Arun");
            que.Enqueue("Srinu");
            foreach (object obj in que)
                Console.WriteLine(obj);
             
           //string str = rque.ToString();
           Console.WriteLine("removed object:{0}",que.Dequeue());
            foreach (object obj in que) 
            Console.WriteLine(obj);

        }
    }
}
