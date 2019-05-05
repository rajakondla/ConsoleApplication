using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface IA
    {
    }

    interface IB
    {

    }

    class AClasses : IA
    {
        protected int a;

        protected virtual int Sum()
        {
            return 1 + 2;
        }

        public void Print()
        {

        }
    }

    class BClass : IB
    {
        protected virtual int Sub()
        {
            return 2 - 1;
        }
    }

    class C : IA, IB
    {
        //public override int Sum()
        //{
        //    return 7 + 8;
        //}
    }

    class TestMultiple
    {
        static void Main()
        {
            IA ia = new AClasses();
        }
    }


    //class Top
    //{
    //    protected int Sum()
    //    {
    //        return 1 + 2;
    //    }
    //}

    //class TestTop : Top
    //{
    //    public int Sum()
    //    {
    //        return 3 + 2;
    //    }
    //}

    class Base
    {
        public string Get { get; set; }
    }

    class Child : Base
    {
        public string Set { get; set; }
    }

    class TestBase
    {
        public void Call(Base baseObj)
        {

        }
    }

    class RunBase
    {
        TestBase testBaseObj = new TestBase();
        public void Main()
        {
            Child childObj = new Child();
            testBaseObj.Call(childObj);
        }
    }
}
