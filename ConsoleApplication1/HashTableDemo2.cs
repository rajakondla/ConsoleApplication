using System;
using System.Collections;

namespace ConsoleApplication1
{
    class HashTableDemo2
    {
        static void Main()
        {
            string key="";
            string value="";
            Hashtable list = new Hashtable();
            list.Add("07331F0034", "Raja Kondla");
            list.Add("07331F0033", "Sapta Giri");
            Console.WriteLine(list.Count);

             // Now to fetch data
            // Create an object of IDictonaryEnumerator , this is an interface that creates an 
            // enumerator and customized for Dictonary objects.

            //IDictionaryEnumerator enumerator = list.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    key += enumerator.Key;
            //    value += enumerator.Value;
            //    key += ", ";
            //    value += ", "; 
            //}
            //using object to retrive key or value
            foreach (object obj in list.Keys)
                Console.WriteLine(obj);
            //using hashtable list as an array like list["07331f0034"] to get value.
            Console.WriteLine("value for 07331f0034:"+ list["07331F0034"]);
            //Console.WriteLine("{0}, {1}", key, value);
            if (list.ContainsKey("07331F0034"))
            {
                Console.WriteLine("Key is found");
            }
            if (list.ContainsValue("Sapta Giri"))
            {
                Console.WriteLine("Value is found");
            }
            //list.Remove("07331F0034");
            IDictionaryEnumerator getenum = list.GetEnumerator();
            while (getenum.MoveNext())
            {
                key += getenum.Key;
                value += getenum.Value;
            }
            Console.WriteLine("{0},{1}", key, value);

        }
    }
}
