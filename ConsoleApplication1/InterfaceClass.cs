using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface ISum
    {
        int Sum(int x, int y);
    }

    public interface ISub
    {
        int Sub(int x, int y);
    }

    public class ImplementSub : ISub
    {
        public int Sub(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    public  class InterfaceClass:ISum
    {
        public virtual int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }

    class NotImplement : InterfaceClass, ISum
    {

    }

    class TestInterfaceClass
    {
        static void Main()
        {
            InterfaceClass iclassObj = new InterfaceClass();
            ISum refiClass = iclassObj;
            int result=refiClass.Sum(4, 5);
        }
    }
}
