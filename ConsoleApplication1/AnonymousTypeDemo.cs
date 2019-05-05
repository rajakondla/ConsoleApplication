using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class AnonymousTypeDemo
    {
        static void Main()
        {
            //var complex = new SortedDictionary<string, DateTime>();
            //complex.Add("Today", DateTime.Now);
            //var c = complex.ToList();
            //foreach (var str in c)
            //    Console.WriteLine(str);
            //var numbers=new[] {"Raja","Arun","Praveen","Srinu"};
            //string[] names = { "Raja", "Arun" };
            //foreach (string v in names)
            //{
            //    var person = new { Name = v,Length=v.Length,Capital=v.ToUpper() };
            //    Console.WriteLine("Name is {0} and the length is {1}. In capitals {2}", person.Name, person.Length,person.Capital);
            //}
            string[] names = {"Srinu","Praveen"};
            foreach (string person in names)
            {
                var get = new { Name = person, Length = person.Length, Capital = person.ToUpper() };
                Console.WriteLine("Name:{0},Length:{1},Capital:{2}", get.Name, get.Length, get.Capital);
            }
        }
    }
}
