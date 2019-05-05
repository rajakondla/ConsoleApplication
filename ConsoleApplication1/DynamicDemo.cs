using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Cricket
    {
        public void CricketPrint()
        {
            Console.WriteLine("Cricket...........");
        }
    }
    class Football
    {
        public void FootballPrint()
        {
            Console.WriteLine("Football..........");
        }
    }
    class DynamicDemo
    {
        static void Main()
        {
            dynamic d;
            d=GetGameOccupation("Football");
            d.FootballPrint();
            dynamic d1 = GetGameOccupation("Cricket");
            d1.CricketPrint();
            try
            {
                d1.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine("no such method-->"+ex.Message);
            }
        }
        public static object GetGameOccupation(string name)
        {
            if (name =="Football")
                return new Football();
            else
                return new Cricket();
        }
    }
}
