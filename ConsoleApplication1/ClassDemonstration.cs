using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  public class ClassDemonstration
   {
    
    //    public static int x = 100;
    //    class GetValue
    //    {
    //        public void Print()
    //        {
    //            Console.WriteLine(x);
    //        }
    //    }
    //    static void Main()
    //    {
    //        GetValue gv = new GetValue();
    //        gv.Print();
    //    }
    //}


    public int x = 100;
     public class GetValue
     {
        
         public void Print()
         {
             ClassDemonstration obj = new ClassDemonstration();
             Console.WriteLine(obj.x);
         }
     }
     static void Main()
     {
        // ClassDemonstration obj1 = new ClassDemonstration();
         //Console.WriteLine(obj1.);
         GetValue gvlObj = new GetValue();
         gvlObj.Print();
     }

      }
}
 
