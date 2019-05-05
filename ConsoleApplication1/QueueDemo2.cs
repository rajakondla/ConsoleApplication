using System;
using System.Collections;
using System.IO;

namespace ConsoleApplication1
{
   
    class QueueDemo2
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"d:\Websites.txt");
            string line = sr.ReadLine();
            Queue que = new Queue();
            que.Enqueue("Raja's collections of websites");
            que.Enqueue("------------------------------");
            while(line!=null)
            {
                if(!que.Contains(line))
                que.Enqueue(line);
                line = sr.ReadLine();
            }
            sr.Close();
           
          
           foreach (object obj in que)
               Console.WriteLine(obj);
        }

    }
}
