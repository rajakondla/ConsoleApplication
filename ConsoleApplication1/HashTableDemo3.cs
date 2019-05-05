using System;
using System.Collections;

namespace ConsoleApplication1
{
    class HashTableDemo3
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("India", "New Delhi");
            ht.Add("Pakistan", "Lahore");
            ICollection getlist = ht.Values;
            ArrayList list = new ArrayList();
            list.AddRange(list);
            string[] str = list.ToArray(typeof(System.String)) as string[];
            foreach (string str1 in str)
                Console.WriteLine(str1);
        }
    }
}
