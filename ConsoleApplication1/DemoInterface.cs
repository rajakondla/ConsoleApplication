using System;
using System.Xml;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApplication1
{
    interface Animal
    {
     //   const int a = 0;
          void Move(int distance);
          void Stop(int stop);
    }

    interface Animal1
    {
        void Move(int distance);
        void Stop(int stop);
    }

    class ToMove 
    {
        public void Move(int distance)
        {
            string s = "";
            Console.WriteLine("flying " + distance + " feet");
        }
    }

    class ToMove1 : Animal
    {
        
         public void Move(int distance)
        {
            Console.WriteLine("Animals from ToMove1");
        }

         public void Stop(int s)
         {
             Console.WriteLine("Animals from ToMove1");
         }
    }

    class TestAnimal
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);

            ArrayList arrList = new ArrayList();
            arrList.Add("");
            arrList.Add(3);


            //Animal an=new ToMove();
            //an.Move(2000);
            Animal obj = new ToMove1();
            obj.Move(1000);
        }
    }

}
