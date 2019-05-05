using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class OptionalParameter
    {
        static void Main()
        {
            OptionalParameter op = new OptionalParameter();
            OptionalParameter op1 = new OptionalParameter();
            op = op1;
            op.Add(1, 2);
        }
        public void Add(int x, int y, int z = 0)
        {
            Sub(x, y);
        }

        public void Sub(int x, int y)
        {

        }
    }
}
