using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    
    
    public class ChangeNotifier
{
    private int num; // Local data
    public event EventHandler NumberChanged; // The event that can be subscribed to
    public ChangeNotifier(int number) { this.num = number; } // Ctor to assign data

    public int Number
    {
        get { return this.num; }
        set
        {
            if (this.num != value) // If the value has changed...
            {
                // Assign the new value to private storage
                this.num = value;

                // And fire the event
                if (this.NumberChanged != null)
                    this.NumberChanged(this, EventArgs.Empty);
            }
        }
    }
}


    public class ChangeNotifier1
    {
        public static void Main()
        {
            ChangeNotifier notifier = new ChangeNotifier(10);

            // Subscribe to the event and output the number when it fires.
            notifier.NumberChanged += (s, e) => Console.WriteLine(notifier.Number.ToString());

            notifier.Number = 10; // Does nothing, this is the same value
            notifier.Number = 20; // Outputs "20" because the event fires and the lambda runs.
        }
    }
    //    protected string name, email;

    //   public SimpleInheritancecs(string name, string email)
    //    {
    //        this.name = name;
    //        this.email = email;
    //    }

    //    protected void Print()
    //    {
    //        Console.WriteLine("Name:{0},Email:{1}", name, email);
    //    }
    //}

    //class getInheritClassEmployee : SimpleInheritancecs
    //{
    //    protected string address="";
    //    public getInheritClassEmployee(string name,string email,string address):base(name,email)
    //    {
    //        this.address = address;
    //    }
    //    protected new void Print()
    //    {

    //    }
}
