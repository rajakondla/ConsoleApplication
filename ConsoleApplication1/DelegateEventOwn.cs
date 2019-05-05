
using System;
namespace ConsoleApplication1
{
    public delegate void NewEmployeeEventHandler(object sender, NewEmployeeEventArgs e);
    class Hr
    {
        public event NewEmployeeEventHandler NewEmployee;

        // To raise an event using OnNewEmployee method
        public void OnNewEmployee(NewEmployeeEventArgs e)
        {
            if (NewEmployee != null)
                NewEmployee(this, e); // conforms the signature of delegate means "this" indicates sender.
                                      // e indicates NewEmployeeEventArgs
        }
        public void RegisterEmployee(string name, string sex, int age)
        {
            NewEmployeeEventArgs e = new NewEmployeeEventArgs(name, sex, age);
            OnNewEmployee(e);
        }
    }
    public class NewEmployeeEventArgs
    {
        public string name;
        public string sex;
        public int age;
        public NewEmployeeEventArgs(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
    }
    class EmployeeCare
    {
        public EmployeeCare(Hr hr)
        {
            hr.NewEmployee += CallEmployee;
        }

        // this CallEmployee is the event handler

        public void CallEmployee(object sender, NewEmployeeEventArgs e)
        {
            Console.WriteLine("sender is" + sender.ToString());
            Console.WriteLine("employee info is:" + e.name + " " + e.sex + " " + e.age);
        }
    }
    class TestEmployeeHr
    {
        static void Main()
        {
            Hr hr = new Hr();
            EmployeeCare ec = new EmployeeCare(hr);
            hr.RegisterEmployee("Raja Kondla", "Male", 23);
            hr.RegisterEmployee("Arun", "Male", 23);
        }
    }
}
