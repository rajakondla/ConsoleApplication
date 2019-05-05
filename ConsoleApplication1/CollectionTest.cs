using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

namespace ConsoleApplication1
{
    class CollectionTest
    {
        static ConcurrentDictionary<string, int> dc = new ConcurrentDictionary<string, int>();
        static Dictionary<string, int> dcc = new Dictionary<string, int>();

        static void Main()
        {
            //Hashtable ht = new Hashtable();
            //ht.Add(1, "Raja");
            //ht.Add(2, null);
            //ht.Add("", new object());
            ////ht.Add(null, "");
            //foreach (DictionaryEntry entry in ht)
            //    Console.WriteLine(entry.Key);

            //Console.Read();

            //Console.WriteLine(ht);

            //Dictionary<int?, string> dc = new Dictionary<int?, string>();
            //dc.Add(null, "Kondla");
            //dc.Add(null, "Raja");
            //foreach (KeyValuePair<int?,string> entry in dc)
            //   Console.WriteLine(entry.Key);

            Thread t1 = new Thread(new ThreadStart(A));
            Thread t2 = new Thread(new ThreadStart(A));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Average {0}", dc.Values.Average());
        }

        static void A()
        {
            for (int i = 0; i < 1000; i++)
            {
                dc.TryAdd(i.ToString(), i);
            }
        }
    }
}
