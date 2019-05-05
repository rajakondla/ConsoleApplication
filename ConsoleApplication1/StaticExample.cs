using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Employee
    {
        private string name, desg;
        private static int count;
        // there should be no access modifiers to static constructors
        static Employee() // called once when the program begins and object of the class is created
        {
            count = 0;
        }
        public Employee(string name, string desg)
        {
            this.name = name;
            this.desg = desg;
            count++;
        }
        public static int GetCount
        {
            get
            {
                return count;
            }
        }
        public static void CountDec()
        {
            count--;
        }
       
    }
    class TestEmployee
    {
        static void Main()
       {
            Employee e = new Employee("RAJA", "Sr .Net developer");
            Employee e1 = new Employee("RAJA", "CEO");
            Employee e2 = new Employee("RAJA", "MVP");
            Employee.CountDec();
            Console.WriteLine(Employee.GetCount);
            
        }
    }
}
