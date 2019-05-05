using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class FactoryDemo
    {
        public int i = 0;
    }


    class Create<T> where T : class,new()
    {
        public static T GetObject()
        {
            return new T();
        }
    }

    class TestFactory
    {
        static void Main()
        {
            FactoryDemo demo = Create<FactoryDemo>.GetObject();
        }
    }

}
