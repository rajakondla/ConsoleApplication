using System;
using System.Collections;


namespace ConsoleApplication1
{
    class SortedListDemo
    {
        static void Main()
        {
            SortedList sl = new SortedList();
            sl.Add("07331f0034", "Raja Kondla");
            sl.Add("07331f0033", "Sapta Giri");
            foreach (DictionaryEntry de in sl)
            Console.WriteLine("{0}, {1}", de.Key, de.Value);
            
        }
    }
}
