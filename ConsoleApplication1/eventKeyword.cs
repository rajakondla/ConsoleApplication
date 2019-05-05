using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    //When you access the Event member from outside the class,
    //the “event” keyword prevents you from both invoking the event as well as from setting the event to null. 
    //But if you remove the event keyword, you can set the delegate to null or even invoke the delegate directly.
    //So essentially the event keyword protects the event from being invoked or 
    //set to null from outside of the class.

   // By using the event keyword you tell C# go generate to hidden methods, 
  //  add_XXX and remove_XXX for your underlying delegate. 
   // This makes sure that anyone using your class can only attach and remove delegates to the event

  // If you don't use event then you're just exposing a public delegate that anyone can add to, 
 //  remove from and invoke. It's highly unlikely that you want anyone other than your class to do the invoking.
    class Program2
    {
        static void Main(string[] args)
        {
            var a = new A1();
            Program2 prog = new Program2();
            a.eventOne += (s, e) => Console.WriteLine("One");
         //   a.eventOne += prog.One;
            a.eventTwo += (s, e) => Console.WriteLine("Two");

            // Calling A1 class methods to invoke delegate methods.
           // a.RaiseOne();
           // a.RaiseTwo();

            // won't compile
             //a.eventOne(prog, EventArgs.Empty);
            a.eventTwo(null, EventArgs.Empty);
           // a.eventOne(prog, EventArgs.Empty);
        }
    }

    class A1
    {
        public event EventHandler eventOne;
        public EventHandler eventTwo;
        int i = 0;
        
       // this part of code is to invoke the method of delegate from class that is having event keyword attached to it.
        //public void RaiseOne()
        //{
        //    if (eventOne != null)
        //        eventOne(this, EventArgs.Empty);
        //}

        //public void RaiseTwo()
        //{
        //    if (eventTwo != null)
        //        eventTwo(this, EventArgs.Empty);
        //}
    }
}
