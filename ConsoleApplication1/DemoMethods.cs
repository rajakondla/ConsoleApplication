using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class DemoMethods
    {
        private int accno;
        public int GetAccno()
        {
            if (accno > 100)
                throw new ArgumentOutOfRangeException("value not passed");
            else
            return accno;
        }
        public void SetAccno(int accno)
        {
            this.accno = accno;
        }
    }
    class TestDemoMethods
    {
        static void Main()
        {
            DemoMethods dm = new DemoMethods();
            dm.SetAccno(101);
            dm.GetAccno();
        }
    }
}
