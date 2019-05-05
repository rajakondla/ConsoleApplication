using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LinkedListDemo
    {
        static void Main()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Raja");
            list.AddAfter(list.Find("Raja"), "Kondla");
            list.AddBefore(list.Find("Kondla"), "Goerge");
            list.AddLast("expert .Net developer");
            foreach (string get in list)
            {
                Console.Write(get);
                Console.Write(" ");
            }
            list.Remove("Goerge");
            Console.WriteLine();
            foreach (string get in list)
            {
                Console.Write(get);
                Console.Write(" ");
            }
        }
    }
}
