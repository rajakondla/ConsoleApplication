using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Employee1
    {
        private string _firstName;
        private string _lastName;
        //private int _empCode;
        private string _designation;

        public Employee1()
        { }
        public Employee1(string firstName, string lastName, string designation)
        {
            _firstName = firstName;
            _lastName = lastName;
            _designation = designation;
        }
        /// <summary>
        /// Property First Name
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        /// <summary>
        /// Property Last Name
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }
    }
    class PredicateExample
    {
        static void Main()
        {
            Employee1 emp1 = new Employee1("Anshu", "Dutta", "SSE");
            Employee1 emp2 = new Employee1("John", "Doe", "Manager");
            Employee1 emp3 = new Employee1("Jane", "Doe", "Assistant");
            // normal delegate on List
            List<Employee1> listEmp = new List<Employee1>{emp1, emp2, emp3};
            Predicate<Employee1> pred = new Predicate<Employee1>(Employee1Check);
            Employee1 emp = listEmp.Find(pred);
            Console.WriteLine("{0} Employee Found", emp.FirstName);

            Console.WriteLine("----------------------------------");
            // normal delegate on Array
            Employee1[] emplist = { emp1, emp2, emp3 };
            Employee1[] result = Array.FindAll(emplist, new Predicate<Employee1>(Employee1Check));
            Console.WriteLine("{0} Employee Found",result[0].FirstName);

            Console.WriteLine("----------------------------------");

            // method group conversion on List
            Employee1 emp5 = listEmp.Find(Employee1Check);
            Console.WriteLine("{0} Employee Found", emp5.FirstName);

            Console.WriteLine("----------------------------------");

            // anonymous delegate
            Employee1[] result1 = Array.FindAll(emplist, delegate(Employee1 empdel)
                                                        {
                                                            if (empdel.FirstName== "John")
                                                                return true;
                                                            else
                                                                return false;
                                                        }
                                              );
            Console.WriteLine("{0} Employee Found", result1[0].FirstName);

        }
        static bool Employee1Check(Employee1 emp)
        {
            if (emp.FirstName == "John")
                return true;
            else
                return false;
        }
    }
}
