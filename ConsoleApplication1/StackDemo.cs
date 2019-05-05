using System;
using System.Collections;
using System.IO;


namespace ConsoleApplication1
{
    class StackDemo
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"d:\Websites.txt");
            string line = sr.ReadLine();
            Stack st = new Stack();
            while (line != null)
            {
                st.Push(line);
                line = sr.ReadLine();
            }
            
                Console.WriteLine(st.Pop());
        }
    }
}
