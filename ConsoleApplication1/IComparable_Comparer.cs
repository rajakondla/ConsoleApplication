using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class EmployeeCompare //: IComparable<EmployeeCompare>//, IEnumerable<EmployeeCompare>
    {
        //string Name = string.Empty;
        //int? salary = null;

        public string EmpName
        {
            get;
            set;
        }

        public int? EmpSalary
        {
            get;
            set;
        }

        //public int CompareTo(EmployeeCompare emp)
        //{
        //    if (this.EmpSalary > emp.EmpSalary)
        //        return 1;
        //    else if (this.EmpSalary < emp.EmpSalary)
        //        return -1;
        //    else return 0;
        //}

    }

    class Company:IEnumerable
    {
        EmployeeCompare[] emp = null;
        public Company(EmployeeCompare[] emp)
        {
            this.emp = emp;
        }
        
        public IEnumerator GetEnumerator()
        {
            return emp.GetEnumerator();
        }
    }

    class EnumEmployee:IEnumerator
    {
        EmployeeCompare[] emp = null;
        int index = -1;
        public EnumEmployee(EmployeeCompare[] emp)
        {
            this.emp = emp;
        }

        public bool MoveNext()
        {
            index++;
            return index < emp.Length;
        }

        public Object Current
        {
            get
            {
                try
                {
                    return emp[index];
                }
                catch (Exception ex)
                {
                    throw new  InvalidOperationException("no elements:"+ex.Message);
                }
            }
        }

        public void Reset()
        {
            index = -1;
        }

       
    }


    class TestEmployeeCompare
    {
        static void Main()
        {
            EmployeeCompare[] empList = new EmployeeCompare[2];
            empList[0]=new EmployeeCompare { EmpName = "Raja", EmpSalary = 10000 };
            empList[1] = new EmployeeCompare { EmpName = "Arun", EmpSalary = 20000 };
          
            Company bf = new Company(empList);
           
            foreach (EmployeeCompare emp in  empList)
            {
                
                Console.WriteLine(emp.EmpName + " " + emp.EmpSalary);
            }
          //  bf.GetEnumerator().Reset();
            foreach (EmployeeCompare emp in bf)
            {
                Console.WriteLine(emp.EmpName + " " + emp.EmpSalary);
            }
            Console.ReadKey();
        }
    }
}
