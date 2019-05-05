using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class DictionaryGenericDemo2
    {
        static void Main()
        {
            var getentry = new Dictionary<int,string>();
            getentry.Add(34,"Raja ");
            getentry.Add(36, "Giri");
            //if (getentry.ContainsKey(34))
            //{
            //    getentry[34]+=1;
            //}
            //Every lookup in a hash on a string key has to compute the hash code,
            //which has a performance penalty. To solve this inefficiency, 
            //use the TryGetValue method. You can store the value it finds.
            string value=string.Empty;
           
                if (getentry.TryGetValue(34, out value))
                {
                    getentry[34] = value + "Kondla";
                }
                else
                    throw new KeyNotFoundException();
                //foreach (KeyValuePair<int, string> kv in getentry)
                foreach(var kv in getentry)
                Console.WriteLine(kv.Value);
                Console.WriteLine(getentry.Count);

                SortedDictionary<int, string> sd = new SortedDictionary<int, string>(getentry);
                foreach (var get in sd)
                    Console.WriteLine(get.Value);
        }
    }
}
