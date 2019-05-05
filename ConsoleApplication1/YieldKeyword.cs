using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Web;

namespace ConsoleApplication1
{
    class YieldKeyword
    {
        //static int SimpleReturn()
        //{
        //    return 1;
        //    return 2;
        //    return 3;
        //}

        //static void Main(string[] args)
        //{
        //    // Lets see how simeple return works
        //    Console.WriteLine(SimpleReturn());
        //    Console.WriteLine(SimpleReturn());
        //    Console.WriteLine(SimpleReturn());
        //    Console.WriteLine(SimpleReturn());
        //}

        static IEnumerable<int> YieldValues()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        static void Main()
        {
            foreach (int i in YieldValues())
            {
                Console.WriteLine(i);
            }
        }

    }

    class MyArrayList : IEnumerable
    {
        object[] m_items = null;
        int index=0;

        public MyArrayList()
        {
            m_items = new object[100];
        }

        public void Add(object item)
        {
            m_items[index] = item;
            index++;
        }

        public IEnumerator GetEnumerator()
        {
           foreach(object obj in m_items)
           {
               if (obj == null)
                   break;
               yield return obj;
           }
        }
    }

    class GetList
    {
        static void Main()
        {
            MyArrayList m_list = new MyArrayList();
            m_list.Add("Raja");
            m_list.Add(2);
            m_list.Add('H');

            foreach (object obj in m_list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
