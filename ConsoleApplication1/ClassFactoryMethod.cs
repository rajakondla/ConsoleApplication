using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public enum employee { raja, praveen, arun, sunil };
    public enum employeeJob { Soft, Mgt, Mech };
    
    public abstract class EmployeeDetails
    {
        public abstract void EmployeeReg();
        protected employeeJob Job
        {
            get;
            private set;
        }
        protected employee Name
        {
            get;
            private set;
        }
        protected EmployeeDetails(employeeJob Job,employee Name)
        {
            this.Job = Job;
            this.Name = Name;
        }
    }

    public class EmployeeDetailsExtension:EmployeeDetails
    {
        public EmployeeDetailsExtension(employeeJob Job,employee name) : base(Job,name)
        {

        }

           public override void EmployeeReg()
           {
            Console.WriteLine("Employee name is {0} and his job is {1}", Name, Job);
            //throw new NotImplementedException();
           }
        
    }

    public class FactoryEmployee
    {
        public static EmployeeDetails FacEmp(employeeJob Job, employee name)
        {
            return new EmployeeDetailsExtension(Job, name);
        }
    }

    public class EmployeeClient
    {
        static void Main()
        {
            EmployeeDetails empDet=FactoryEmployee.FacEmp(employeeJob.Mech, employee.raja);
            empDet.EmployeeReg();
        }
    }
}
