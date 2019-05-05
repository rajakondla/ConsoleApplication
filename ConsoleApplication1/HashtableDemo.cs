using System;
using System.Collections;


namespace ConsoleApplication1
{
    class HashtableDemo
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("07331f0034", "Raja Kondla");
            ht.Add("07331f0003", "Giri HemaSundra");
            foreach (DictionaryEntry de in ht)
                Console.WriteLine("key is:{0}, value is:{1}", de.Key, de.Value);
        }
    }
}
