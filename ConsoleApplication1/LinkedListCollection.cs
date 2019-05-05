using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LinkedListCollection
    {
        static void Main()
        {
            LinkedList<string> lk = new LinkedList<string>();
            lk.AddFirst("Raja");
            lk.AddAfter(lk.Find("Raja"), "Kondla");
            lk.AddBefore(lk.Find("Raja"), "Mr. ");
            lk.AddLast(" Senior Software Engineer");

            foreach (string str in lk)
                Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
