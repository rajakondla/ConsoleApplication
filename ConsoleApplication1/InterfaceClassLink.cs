using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface IMath
    {
        int Sum(int x, int y);
        int Multiply(int x,int y);
    }

    class Maths:IMath
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x*y;
        }
    }

    class MathsExtend : Maths
    {
        public int Division(int x, int y)
        {
            return x / y;
        }
    }

    class MathsCall
    {
        public MathsExtend mExtend { get; set; }
    }

    class TestMaths
    {
        public static void Main(MathsCall maths)
        {
            maths.mExtend.Multiply(2, 3);
        }
    }
}

