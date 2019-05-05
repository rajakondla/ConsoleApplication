using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class DictionaryGenericDEmo
    {
        static void Main()
        {
            Dictionary< int,string> getentry = new Dictionary< int,string>();
            getentry.Add( 34,"Raja Kondla");
            getentry.Add( 33,"Sapta Giri");
            getentry.Add( 19,"Kiran Terapalli");
            getentry.Add( 60,"Yogesh Dasari");
            foreach (KeyValuePair<int, string> de in getentry)
                Console.WriteLine("{0}, {1}", de.Key, de.Value);
            if (getentry.ContainsKey(34))
            {
                string name = getentry[34];
                Console.WriteLine(name);
            }
            if (getentry.ContainsValue("Raja Kondla"))
                Console.WriteLine("Raja Kondla is there!");
        }

    }
}
