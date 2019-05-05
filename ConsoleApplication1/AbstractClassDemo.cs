using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
   class AbstractClassDemo
    {
       string Name,SurName=string.Empty;
       public AbstractClassDemo(string Name,string SurName)
       {
           this.Name = Name;
           this.SurName = SurName;
       }
       public void Print()
       {
           Console.WriteLine("{0} {1}", Name, SurName);
       }
    }

   class RunAbstract
   {
       static void Main()
       {
           AbstractClassDemo obj = new AbstractClassDemo("Raja", "Kondla");
           obj.Print();
           AbstractClassDemo obj1 = new AbstractClassDemo("Praveen", "Nagasuri");
           obj1.Print(); 
       }
   }

 
}
