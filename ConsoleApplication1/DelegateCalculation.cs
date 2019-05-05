using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public delegate int Calculate(int x,int y);
    class AddMultiply
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
    class Process
    {
        AddMultiply obj1;
        int fvalue, svalue;
        public void MySecondObj()
        {
            fvalue = 7;
            svalue = 5;
            obj1 = new AddMultiply();
        }
        public int Do(string input)
        {
            Calculate cal=null;
            switch (input)
            {
                case "Add": cal = obj1.Add;
                    break;
                case "Mul": cal = obj1.Multiply;
                    break;
                case "Sub": cal = this.Subtract;
                    break;
                default: goto examin;
            }
        examin:
            if (cal == null)
                throw new Exception("Enter one among them!");
            else
            return cal(fvalue, svalue);
        }
        public int Subtract(int x, int y) // not even static should present
        {
            if (x < y)
                return 1;
            else
                return x - y;
        }
    }
    class TestProcess
    {
        static void Main()
        {
            Process p = new Process();
            Console.WriteLine(p.Do("Sub"));
            Console.WriteLine(p.Do("Add"));
        }
    }

}
