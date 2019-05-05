using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Person2
    {
        protected string name = "";
        public Person2(string name)
        {
            this.name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine(name);
        }
    }

    class Employee2 : Person2
    {
        string lastName = "";
        string address = "";
        public Employee2(string name2,string lastName, string address)
            : base(name2)
        {
            this.lastName = lastName;
            this.address = address;
        }

        public override void Print()
        {
            Console.WriteLine("Name:" + name + " LastName:" + lastName + " Address:" + address);
        }
    }

    class TestConstructor
    {
        static void Main()
        {
            Employee2 emp = new Employee2("Raja", "Kondla", "Door No: 21-22-3");
            emp.Print();
            Person2 person = emp;
            person.Print();
        }
    }

}
