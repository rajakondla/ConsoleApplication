using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class2
    {
        static void Main()
        {
            //   DemoMatrix demo=new DemoMatrix();
            //  demo.Print();

            //LinkedList<int> ll = new LinkedList<int>();
            //ll.AddFirst(1);
            //ll.AddAfter(ll.Find(1), 2);
            //ll.AddAfter(ll.Find(2), 3);
            //ll.AddAfter(ll.Find(3), 4);
            //ll.AddAfter(ll.Find(4), 5);
            //ll.AddAfter(ll.Find(5), 6);
            //ll.AddAfter(ll.Find(6), 7);

            //int i = 0;

            string msg = "This is a message.";
            string k = "SmartBuy"; // For example, use '.' as key. You can also use another key.
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < msg.Length; i++)
            {
                sb.Append((char)(msg[i] ^ k[i % k.Length]));
            }
            Console.WriteLine(sb.ToString());

            Console.ReadKey();
            StringBuilder sb1 = new StringBuilder();
            for (int i = 0; i < sb.Length; i++)
            {
                sb1.Append((char)(sb[i] ^ k[i % k.Length]));
            }
            Console.WriteLine(sb1.ToString());

            Console.ReadKey();
        }
    }
}
