using System;
using System.Collections;
using System.IO;

namespace ConsoleApplication1
{
    class ArrayList2Demo
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            try
            {
                StreamReader sr = new StreamReader(@"d:\Websites.txt");
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (!al.Contains(line))
                        al.Add(line);
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException("no such file", ex.Message);
            }
            foreach (object obj in al)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }

    }
}
