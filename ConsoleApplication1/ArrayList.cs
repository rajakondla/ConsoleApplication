using System;
using System.Collections;


namespace ConsoleApplication1
{
    class ArrayListDemo
    {
        static void Main()
        {
            ArrayList items = new ArrayList();
            items.Add("Keyboard");
            items.Add("Mouse");
            items.Add(3);
            ArrayList items1 = new ArrayList();
            items1.Add("CPU");
            items1.Add("Mother board");
            items.AddRange(items1);
            Console.WriteLine("no of items:"+items.Count);
            items.Remove("Mouse");
            items.RemoveAt(2);
            items.Insert(0, "Computer");
            Example(items);
            Console.WriteLine();
        }
          public static void Example(ArrayList list)
          {
            for(int i=0;i<list.Count;i++)
            {
                string getitems=list[i] as string;
                  Console.WriteLine(getitems);  
            }
            Console.WriteLine("Output from GetRange:");
            ArrayList range = list.GetRange(1, 3);
            foreach (object get in range)
                Console.WriteLine(get);
          }
          }
        }
    



