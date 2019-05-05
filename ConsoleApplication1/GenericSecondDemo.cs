using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class GenericSecondDemo<T>
    {
        T[] array = new T[10];
        int i = 0;
        public void Insert(T value)
        {
            array[i] = value;
            i++;
        }
        public T Get
        {
            get
            {
                return array[1];
            }
        }
    }

    public class GetGeneric
    {
        static void Main()
        {
            GenericSecondDemo<int> intGen = new GenericSecondDemo<int>();
            intGen.Insert(10);
            intGen.Insert(20);
            GenericSecondDemo<string> strGen = new GenericSecondDemo<string>();
            strGen.Insert("");
            Console.WriteLine(intGen.Get);
        }
    }

    class Pointers
    {
        static void Main()
        {
            Pointers p = new Pointers();
            //dynamic d = p.Add();
            //d = p.sub;
        }

        public object Add()
        {
            return null;
        }
    }
}
