using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class EmployeeEntries
    {
        public string name;
        public string sex;
        public int age;
        public EmployeeEntries(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
    }
    class GetEmployee<T> where T : EmployeeEntries
    {
        string name;
        string sex;
        int age;
        public void Print(string name, string sex, int age)
        {
            Console.WriteLine("{0},{1},{2}", this.name = name, this.sex = sex, this.age = age);
        }
    }
    class TestOwn
    {
        static void Main()
        {
            EmployeeEntries ee = new EmployeeEntries("Praveen", "male", 23);
            GetEmployee<EmployeeEntries> gt = new GetEmployee<EmployeeEntries>();
            gt.Print(ee.name, ee.sex, ee.age);
        }
    }

    class Division
    {
        public delegate void EventHandler(Object sender, DivisionEventArgs e); //Delegate
        public event EventHandler DivisionDone; //This event will be executed when the divison will be done.
        public event EventHandler DivisionPerZero; //This event will be executed when the divisor is 0.

        public Division() //Constructor
        {

        }

        public void Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                if (DivisionPerZero != null)
                {
                    DivisionPerZero(this, new DivisionEventArgs(dividend, divisor, 0.0)); //Execute the DivisionPerZero event
                    return;
                }
            }

            double num = dividend / divisor;

            if (DivisionDone != null)
            {
                DivisionDone(this, new DivisionEventArgs(dividend, divisor, num)); //Execute the DivisionDone event
            }
        }
    }

    class DivisionEventArgs : EventArgs //The arguments of the division.
    {
        private int dividend;
        private int divisor;
        private double result;
        public DivisionEventArgs(int a, int b, double r)
        {
            dividend = a;
            divisor = b;
            result = r;
        }

        public int Dividend
        {
            get { return dividend; }
        }

        public int Divisor
        {
            get { return divisor; }
        }

        public double Result
        {
            get { return result; }
        }

        public string Error
        {
            get
            {
                if(divisor == 0)
                  return "Divisor cannot be zero";
                else
                  return "Divisor is ok to go";
            }
        }
    }

    //class DivisionEvent
    //{
    //    static void Main()
    //    {
    //        Division divClient = new Division();
    //         Division divClient1 = new Division();
    //        divClient.DivisionPerZero=delegate(Division divClient1,new DivisionEventArgs(10,5,0.0))
    //            {

    //            };
    //    }
    //}
}

