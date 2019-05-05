using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LinqTest
    {
        static void Main()
        {
            Dictionary<int, string> getentry = new Dictionary<int, string>();
            getentry.Add(2, "Dhana Laxmi");
            getentry.Add(1, "Allu Suresh");
            getentry.Add(3, "Bhanu Prakesh");
            Dictionary<int, string> getentry1 = new Dictionary<int, string>();
            getentry1.Add(34, "Raja Kondla");
            getentry1.Add(33, "Giri");
            getentry1.Add(59, "Yenda Mahesh Kumar");
            getentry1.Add(1, "Allu Suresh");
            getentry1.Add(2, "Dhana Laxmi");
            var getresult = (from get in getentry.Keys 
                             join jo in getentry1.Keys
                             on getentry[get] equals getentry1[jo] 
                             orderby getentry[get]
                             select get);
            foreach (int retrieve in getresult)
                Console.WriteLine("{0}, {1}", retrieve, getentry[retrieve]);

            //By using the ToDictionary method, which is an extension method on IEnumerable that will place 
            //the keys and values into a new Dictionary using lambda expressions.
            // ToDictionary is from System.Linq namespace
            string[] names = new string[]
            {
                "Raja Kondla",
                "Sapta Giri"
            };
            var dic = names.ToDictionary(items => items, items => true);
                foreach(var get in dic)
                    Console.WriteLine("{0}, {1}",get.Key,get.Value);
        }

    } 
}
