using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class ShowFileDetails
    {
        static void Main()
        {
            FileInfo fi = new FileInfo("d:\\message.txt");
            fi.Encrypt();
            Console.WriteLine("Full name:{0}", fi.FullName);
            Console.WriteLine("Length:{0}", fi.Length);
            Console.WriteLine("Directory:{0}", fi.DirectoryName);
            Console.WriteLine("Created:{0}", fi.CreationTime);
            Console.WriteLine("Security:{0}",(fi.IsReadOnly)?"Read only":"Read-write");
            string fd=@"d:\message.txt";
            StreamReader sr = new StreamReader(fd);
            Console.WriteLine("Content is:{0}",sr.ReadToEnd());
        }
    }
}
