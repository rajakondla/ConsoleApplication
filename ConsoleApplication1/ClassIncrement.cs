using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ClassIncrement
    {
        int i = 0;
        static void Main()
        {
            ClassIncrement obj = new ClassIncrement();
            obj.Inc();
            obj.Show();
        }

        public void Inc()
        {
            i++;
        }
        public  void Show()
        {
            Console.WriteLine(i);
        }
    }
}
