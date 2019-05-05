using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    class FileSystemMgt
    {
        static void Main()
        {
            string sb ="";
            StreamReader str = new StreamReader(@"D:\Websites2.txt");
            while (str.EndOfStream == false)
            {
               // if (str.ReadLine() != "") 
               // sb = str.ReadLine();
                //if (!string.IsNullOrEmpty(sb))
                if (str.ReadLine() != null || str.ReadLine() != "")
                {
                    sb += str.ReadLine();
                    Console.WriteLine(sb);
                }
            }
           
        }
    }


    //static class StreamReaderExtensions
    //{
    //    public static IEnumerable<string> Lines(this StreamReader reader)
    //    {
    //        string line;
    //        while ((line = reader.ReadLine()) != null)
    //            yield return line;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        using (StreamReader reader = new StreamReader(path))
    //        {
    //            var lines = from line in reader.Lines()
    //                        where !string.IsNullOrEmpty(line)
    //                        select line;
    //            foreach (var line in lines)
    //                Console.WriteLine(line);
    //        }
    //    }
    //}
}
