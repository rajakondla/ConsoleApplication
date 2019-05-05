using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ListGenericDemo
    {
        static void Main()
        {
            int[] numbers = { 2, 3, 4, 5, 6, 6 };
            List<int> list = new List<int>(numbers);
            Console.WriteLine("number of elements:" + list.Count);
            foreach (int getlist in list)
                Console.WriteLine(getlist);
            Console.WriteLine("Prime numbers starts here");
            List<int> pnumbers=new List<int>(new int[] {2,3,5,7,11});
            int num = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < pnumbers.Count; i++)
            {
                if (pnumbers[i] == num)
                    Console.WriteLine("number is there in list");
                
            }
        
        }
    }
}
