using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class DictionaryDemoMethods
    {
        public Dictionary<string, string> GetData()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Tution Lover", "Laxmi");
            d.Add("School Lover", "Revathi");
            d.Add("Universal Lover", "Archana");

            return d;
        }
        public void CheckContains(Dictionary<string, string> get)
        {
            if (get.ContainsKey("Tution Lover"))
                Console.WriteLine(get["Tution Lover"]);
        }
        static void Main()
        {
            DictionaryDemoMethods dem = new DictionaryDemoMethods();
            dem.CheckContains(dem.GetData());
        }
            
    }
}
