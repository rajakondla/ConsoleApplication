using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class NoOfDirectories
    {
        static void Main()
        {
        DriveInfo[] dif=DriveInfo.GetDrives();
        Console.WriteLine("Drives are:");
        foreach (DriveInfo getdrives in dif)
            Console.WriteLine(" {0} {1}", getdrives.Name, getdrives.DriveType);
        }
    }
}
