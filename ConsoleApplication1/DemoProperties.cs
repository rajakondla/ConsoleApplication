using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class DemoProperties
    {
        private int accno;
        public int AccnoProperty
        {
            get
            {
                    return accno;
            }
            set
            {
                if (value > 50)
                    throw new ArgumentException("cannt pass value greater than 50");
                else
                    accno = value;
                
            }
        }
    }
    class TestDemoProperties
    {
        static void Main()
        {
            DemoProperties dp = new DemoProperties();
            dp.AccnoProperty = 2;
               Console.WriteLine (dp.AccnoProperty);
        }
    }
}
