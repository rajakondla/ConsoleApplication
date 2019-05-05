using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Display
    {
        static void Main()
        {
            //Hash h1 = new Hash { Name="Raja Kondla" };
            //Hash h2 = new Hash { Name = "Sheri Begum" };

            //Dictionary<int, string> dic1 = new Dictionary<int, string>();
            //dic1.Add(1, "Raja Kondla");
            //dic1.Add(2, "Sheri Begum");

            //Dictionary<int, string> dic2 = new Dictionary<int, string>(dic1);

            //dic2[2] = "Sheri Kondla";
            //Console.WriteLine(dic1[2]);

            Display dObj = new Display();
            Thread t=new Thread(dObj.DoSomeWork);
            t.Start();
            Console.WriteLine("------Print------");
            Thread.Sleep(10000);
            t.Abort();
            Console.ReadKey();
        }

        class Hash
        {
            public string Name { get; set; }
        }

        public void DoSomeWork()
        {
           
                for (int i = 0; i < 10000000; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
          
        }

    }
}
